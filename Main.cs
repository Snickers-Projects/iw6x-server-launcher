using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace iw6x_server_launcher
{
    public partial class Main : Form
    {
        private string app = "iw6x.exe";
        private string xlabs_app = "xlabs.exe";
        private string xlabs_app_full = "";
        private string server_config = "server.cfg";
        private string LocalAppData = Environment.GetEnvironmentVariable("LocalAppData");
        private string port = "28960";
        //private string game_location = "%~dp0";
        private string game_location = "";
        private string sv_lanonly = "0";
        private string iw6x_location = "";
        private string command = "";
        private string config_file = "launcher.ini";
        private string launch_config = "";
        private string server_randomize = "0";

        private string   server_config_gamemode = "unknown";
        private string[] server_config_maps;


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // We need to set the "XLABS_GHOSTS_INSTALL" environment variable to the game location
            iw6x_location = Path.Combine(LocalAppData, "xlabs", "data", "iw6x", app);
            game_location = Directory.GetCurrentDirectory();
            Environment.SetEnvironmentVariable("XLABS_GHOSTS_INSTALL", game_location);

            xlabs_app_full = Path.Combine(game_location, xlabs_app);
            config_file = Path.Combine(game_location, config_file);

            // Update text fields
            textPort.Text       = port = IniFile.ReadValue(config_file, "server", "port");
            checkUpdate.Checked = IniFile.ReadValue(config_file, "server", "update") == "1" ? true : false;
            checkOnline.Checked = IniFile.ReadValue(config_file, "server", "online") == "1" ? true : false;
            sv_lanonly          = IniFile.ReadValue(config_file, "server", "online") == "1" ? "1" : "0";
            checkBoxMapRandom.Checked = IniFile.ReadValue(config_file, "server", "randomize_maps") == "1" ? true :false;
            textBoxDirectConnect.Text = IniFile.ReadValue(config_file, "client", "last_ip");

            // Update the IP list
            updateIP_list();

            // Update listbox
            populateConfigList();

            // Select config from ini and update the listbox
            if(listBoxConfigs.Items.Count > 0)
            {
                listBoxConfigs.SelectedIndex = 0;
            }

            launch_config = IniFile.ReadValue(config_file, "server", "server_config");
            if(launch_config != "")
            {
                listBoxConfigs.SelectedIndex = listBoxConfigs.FindStringExact(launch_config);
            }
        }

        private void Singleplayer_Click(object sender, EventArgs e)
        {
            command = "-singleplayer";
            launch();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            command = "-multiplayer";
            launch();
        }

        /**
         * Launches the game with all the settings
         */

        private void launch()
        {
            var p = new Process();

            // Update the config file
            IniFile.WriteValue(config_file, "server", "port", textPort.Text);
            IniFile.WriteValue(config_file, "server", "update", checkUpdate.Checked ? "1" : "0");
            IniFile.WriteValue(config_file, "server", "online", checkOnline.Checked ? "1" : "0");
            if(listBoxConfigs.SelectedIndex > 0)
            {
                launch_config = listBoxConfigs.SelectedItem.ToString();
                IniFile.WriteValue(config_file, "server", "server_config", launch_config);
            }

            // Update check, only continue once update closes
            if ( checkUpdate.Checked )
            {
                var up = new Process();
                up.StartInfo.FileName = xlabs_app_full;
                up.StartInfo.Arguments = "-update";
                up.Start();
                up.WaitForExit();
            }

            // Launch the game
            p.StartInfo.FileName = iw6x_location;
            p.StartInfo.Arguments = command;
            //MessageBox.Show(iw6x_location + " " + p.StartInfo.Arguments);
            p.Start();
        }

        /**
         * Loops though the config files and populates the listbox
         * 
         */
        private void populateConfigList()
        {
            string config_path = Path.Combine(game_location, "iw6x");
            if (!Directory.Exists(config_path)) return;

            // Get a list of config files from the iw6x folder within the game
            string[] config_files = Directory.GetFiles(Path.Combine(game_location, "iw6x"), "*.cfg");

            // Update the listbox
            listBoxConfigs.Items.Clear();
            foreach (string file in config_files)
            {
                // Just add the file name
                listBoxConfigs.Items.Add(Path.GetFileName(file));
            }
        }

        private void btnDedicated_Click(object sender, EventArgs e)
        {
            // Check if there are any configs in the list, if there aren't, just return
            if(listBoxConfigs.Items.Count == 0)
            {
                MessageBox.Show("No config files found");
                return;
            }

            // Get selected config from list
            launch_config = listBoxConfigs.SelectedItem.ToString();


            // Update the config file
            IniFile.WriteValue(config_file, "server", "server_config", launch_config);
            if(checkBoxMapRandom.Checked)
            {
                IniFile.WriteValue(config_file, "server", "randomize_maps", "1");
            }
            else
            {
                IniFile.WriteValue(config_file, "server", "randomize_maps", "0");
            }

            string aliens_mode = "";

            if(detectAliensMode(launch_config))
            {
                aliens_mode = " +set zombiesMode 1";
            }

            string lan_string = "";

            // Lan String
            if (checkOnline.Checked)
            {
                lan_string = " +set sv_lanonly 1";
            }

            // Randomize maps if checked
            if (checkBoxMapRandom.Checked)
            {
                randomizeMapRotation(launch_config);
            }

            // Update command_suffix
            command = "-dedicated +set net_port " + port + aliens_mode + lan_string + " +exec " + launch_config + " +map_rotate";

            // return;
            // Launch
            launch();

        }

        private void listBoxConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            launch_config = listBoxConfigs.SelectedItem.ToString();
            string configPath = Path.Combine(game_location, "iw6x", launch_config);

            labelGameModeValue.Text = "Unknown";
            labelPlayersValue.Text = "Unknown";

            if (checkMapRotation(configPath))
            {
                labelGameModeValue.Text = gameModeLookup(server_config_gamemode);
            }


            string NumberOfPlayers = readConfigValue(launch_config, "set sv_maxclients");
            if(NumberOfPlayers != "")
            {
                Console.WriteLine("Number of players: " + NumberOfPlayers);
                labelPlayersValue.Text = NumberOfPlayers;
            }

        }

        private void buttonPortDefault_Click(object sender, EventArgs e)
        {
            // Set port to default port 27016
            textPort.Text = "27016";

        }

        private void checkOnline_CheckedChanged(object sender, EventArgs e)
        {
            // Update sv_lanonly if checked
            if (checkOnline.Checked)
            {
                sv_lanonly = "0";
            }
            else
            { 
                sv_lanonly = "1";
            }
        }

        private void checkBoxMapRandom_CheckedChanged(object sender, EventArgs e)
        {
            // Update server_randomized if checked
            if (checkBoxMapRandom.Checked)
            {
                server_randomize = "1";
            }
            else
            {
                server_randomize = "0";
            }
        }

        /**
         * Get all IP's on the host computer
         * 
         */
        public void updateIP_list()
        {
            List<string> ipAddresses = new List<string>();
            List<string> externalIPs = new List<string>();


            // Get all active network IP's and add them to a list
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            // Ignore loopback IP's
                            if (ip.Address.ToString() != "127.0.0.1")
                            ipAddresses.Add(ip.Address.ToString());
                        }
                    }
                }
            }

            // Get Local IP and show it
            listBoxLocalIp.Items.Clear();

            foreach (string ip in ipAddresses)
            {
                listBoxLocalIp.Items.Add(ip);
            }

            // Get External IP if possible
            if (!NetworkInterface.GetIsNetworkAvailable()) return;


            // Get External IP, but don't try too long since it's not important.
            try
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send("icanhazip.com", 400);
                if (reply.Status != IPStatus.Success)
                {
                    return;
                }

                string externalIp = new WebClient().DownloadString("http://icanhazip.com");
                // If it's a valid IP, add it to the list
                if (externalIp != null && externalIp != "")
                    externalIPs.Add(externalIp);

                // Add external IP's to listbox
                foreach (string ip in externalIPs)
                {
                    listBoxExternalIp.Items.Add(ip);
                }
            }
            catch (Exception)
            {
                return;
            }


        }

        private bool detectAliensMode(string configFile)
        {
            // Get Config file path Directory.GetFiles(Path.Combine(game_location, "iw6x"), "*.cfg");
            string configPath = Path.Combine(game_location, "iw6x", configFile);

            // Check if file exists, Read the file contents to see if "set scr_aliens" exists
            if (File.Exists(configPath))
            {
                // Read the file contents
                string fileContents = File.ReadAllText(configPath);

                // Check if the file contains the aliens mode code
                if (fileContents.Contains("set scr_aliens"))
                {
                    //MessageBox.Show("Aliens!");
                    return true;
                }
            }

            return false;
        }

        /**
         * Opens currenly selected server config
         */ 
        private void buttonOpenConfig_Click(object sender, EventArgs e)
        {
            // Get selected config from list
            if (listBoxConfigs.SelectedItem == null) return;

            launch_config = listBoxConfigs.SelectedItem.ToString();

            // Open config in notepad
            Process.Start(Path.Combine(game_location, "iw6x", launch_config));
        }

        private void buttonLocalConnect_Click(object sender, EventArgs e)
        {
            string IpAddr = textBoxDirectConnect.Text;

            // Save IP to config
            IniFile.WriteValue(config_file, "client", "last_ip", IpAddr);

            command = "-multiplayer +connect " + IpAddr;
            launch();
        }

        private bool checkMapRotation(string configFile)
        {
            string configPath = Path.Combine(game_location, "iw6x", configFile);

            if (!File.Exists(configPath)) return false;

            // Read the file contents
            string fileContents = File.ReadAllText(configPath);

            // We need to see if "set sv_maprotation" exists, if so, we need to randomize it
            if (!fileContents.Contains("set sv_maprotation")) return false;

            // Get the current map rotation, this is in the file, starts with "set sv_maprotation" and has a value in quotes
            string mapRotation = Regex.Match(fileContents, "set sv_maprotation \"(.*?)\"").Groups[1].Value;

            // Get gametype from map rotation so we can add it all back later
            string gametype = Regex.Match(mapRotation, "gametype (.*?) ").Groups[1].Value;

            // Remove "gametype " and the following word from the full string
            mapRotation = Regex.Replace(mapRotation, "gametype \\w+ ", "");

            // Split the map rotation into an array of maps skipping the "map " part
            string[] maps = Regex.Split(mapRotation, "map ");


            server_config_gamemode = gametype;
            server_config_maps     = maps;

            return true;
        }

        private void randomizeMapRotation(string configFile)
        {
            if (!checkMapRotation(configFile)) return;

            string configPath = Path.Combine(game_location, "iw6x", configFile);
            string fileContents = File.ReadAllText(configPath);

            if (!File.Exists(configPath)) return;

            string[] maps = server_config_maps;
            string gametype = server_config_gamemode;

            // Randomize the map rotation
            Random rnd = new Random();
            maps = maps.OrderBy(x => rnd.Next()).ToArray();

            // Rebuild the map rotation string
            string mapRotation = "map " + string.Join("map ", maps);

            // Add gametype back to the map rotation
            mapRotation = "gametype " + gametype + " " + mapRotation;

            // Remove last space
            mapRotation = mapRotation.TrimEnd();

            // Replace the old map rotation with the new one
            fileContents = Regex.Replace(fileContents, "set sv_maprotation \"(.*?)\"", "set sv_maprotation \"" + mapRotation + "\"");

            // Write the new file contents
            File.WriteAllText(configPath, fileContents);
        }

        private string gameModeLookup(string gameMode)
        {
            if (gameMode == "blitz")    return "Blitz";
            if (gameMode == "conf")     return "Kill Confirmed";
            if (gameMode == "cranked")  return "Cranked";
            if (gameMode == "dm")       return "Free-for-all";
            if (gameMode == "dom")      return "Domination";
            if (gameMode == "grind")    return "Grind";
            if (gameMode == "grnd")     return "Drop Zone";
            if (gameMode == "gun")      return "Gun Game";
            if (gameMode == "horde")    return "Safeguard";
            if (gameMode == "infect")   return "Infected";
            if (gameMode == "sd")       return "Search and Destroy";
            if (gameMode == "siege")    return "Reinforce";
            if (gameMode == "sotf")     return "Hunted";
            if (gameMode == "sotf_ffa") return "Hunted FFA";
            if (gameMode == "sr")       return "Search and Rescue";
            if (gameMode == "war")      return "Team Deathmatch";
            if (gameMode == "aliens")   return "Aliens";

            return "unknown";
        }

        private string readConfigValue(string configFile, string key)
        {
            string configPath = Path.Combine(game_location, "iw6x", configFile);

            string value = null;
            string[] lines = File.ReadAllLines(configPath);
            foreach (string line in lines)
            {
                string trimmedLine = line.Trim();
                int commentIndex = trimmedLine.IndexOf("//");
                if (commentIndex != -1)
                {
                    trimmedLine = trimmedLine.Substring(0, commentIndex).Trim();
                }
                if (trimmedLine.StartsWith(key))
                {
                    int equalsIndex = trimmedLine.IndexOf("=");
                    if (equalsIndex != -1)
                    {
                        value = trimmedLine.Substring(equalsIndex + 1).Trim();
                    }
                    break;
                }
            }
            return value;
        }
    }
}
