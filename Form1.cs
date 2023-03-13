using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
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
        private string game_location = "G:\\xlabs\\iw6x_full_game";
        private string sv_lanonly = "0";
        private string iw6x_location = "";
        private string command = "";
        private string config_file = "launcher.ini";
        private string launch_config = "";


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // We need to set the "XLABS_GHOSTS_INSTALL" environment variable to the game location
            Environment.SetEnvironmentVariable("XLABS_GHOSTS_INSTALL", game_location);
            iw6x_location = Path.Combine(LocalAppData, "xlabs", "data", "iw6x", app);
            // game_location = Directory.GetCurrentDirectory();

            xlabs_app_full = Path.Combine(game_location, xlabs_app);
            config_file = Path.Combine(game_location, config_file);

            // Update text fields
            textPort.Text       = port = IniFile.ReadValue(config_file, "server", "port");
            checkUpdate.Checked = IniFile.ReadValue(config_file, "server", "update") == "1" ? true : false;
            checkOnline.Checked = IniFile.ReadValue(config_file, "server", "online") == "1" ? true : false;
            sv_lanonly          = IniFile.ReadValue(config_file, "server", "online") == "1" ? "1" : "0";

            // Update the IP list
            updateIP_list();

            // Update listbox
            populateConfigList();

            // Select config from ini and update the listbox
            listBoxConfigs.SelectedIndex = 0;
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
            // Get a list of config files from the iw6x folder within the game
            string[] config_files = Directory.GetFiles(Path.Combine(game_location, "iw6x"), "*.cfg");

            // Update the listbox
            listBoxConfigs.Items.Clear();
            foreach (string file in config_files)
            {
                // Just add the file name without the extension

                listBoxConfigs.Items.Add(Path.GetFileName(file));
            }
        }

        private void btnDedicated_Click(object sender, EventArgs e)
        {
            // Get selected config from list
            launch_config = listBoxConfigs.SelectedItem.ToString();

            // Update the config file
            IniFile.WriteValue(config_file, "server", "server_config", launch_config);

            string aliens_mode = "";

            if(detectAliensMode(launch_config))
            {
                aliens_mode = " +set zombiesMode 1";
            }

            // Update command_suffix
            command = "-dedicated +set net_port " + port + aliens_mode + " +set sv_lanonly " + sv_lanonly + " +exec " + launch_config + " +map_rotate";


            // Launch
            launch();

        }

        private void listBoxConfigs_SelectedIndexChanged(object sender, EventArgs e)
        {
            launch_config = listBoxConfigs.SelectedItem.ToString();
            labelModeText.Text = "Multiplayer";
            if (detectAliensMode(launch_config)) labelModeText.Text = "Aliens";

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

            // Get External IP
            string externalIp = new WebClient().DownloadString("http://icanhazip.com");
            // If it's a valid IP, add it to the list
            if (externalIp != null && externalIp != "")
                externalIPs.Add(externalIp);

            // Clear listbox
            listBoxLocalIp.Items.Clear();

            // Add IP's to listbox
            foreach (string ip in ipAddresses)
            {
                listBoxLocalIp.Items.Add(ip);
            }

            // Add external IP's to listbox
            foreach (string ip in externalIPs)
            {
                listBoxExternalIp.Items.Add(ip);
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
            launch_config = listBoxConfigs.SelectedItem.ToString();

            // Open config in notepad
            Process.Start(Path.Combine(game_location, "iw6x", launch_config));
        }
    }
}
