using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace iw6x_server_launcher
{
    public partial class ServerConfigCreator : Form
    {
        private bool advancedSettingsLoaded = false;
        private const string ServerDataFile = "iw6\\GameserverInfo.json";
        private JObject serverData;
        private string selectedGameCategory = "";
        private string selectedGameMode = "";

        public ServerConfigCreator()
        {
            InitializeComponent();
            LoadServerData();
            InitializeUI();
        }

        private void LoadServerData()
        {
            try
            {
                string dataPath = Path.Combine(Directory.GetCurrentDirectory(), ServerDataFile);
                if (File.Exists(dataPath))
                {
                    string jsonContent = File.ReadAllText(dataPath);
                    serverData = JObject.Parse(jsonContent);
                }
                else
                {
                    MessageBox.Show($"Server data file not found: {dataPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading server data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void InitializeUI()
        {
            comboGameCategory.Items.AddRange(new object[] { "Multiplayer", "Aliens", "Safeguard" });
            comboGameCategory.SelectedIndex = 0;
            
            textFilename.Text = "server.cfg";
            
            LoadGeneralSettings();

            // Hide advanced settings tabs until the user requests them
            if (tabControl.TabPages.Contains(tabIW6Mod))
            {
                tabControl.TabPages.Remove(tabIW6Mod);
            }

            if (tabControl.TabPages.Contains(tabBaseGame))
            {
                tabControl.TabPages.Remove(tabBaseGame);
            }
        }

        private void LoadGeneralSettings()
        {
            panelGeneralSettings.Controls.Clear();
            
            var generalSettings = serverData["generalSettings"] as JArray;
            int yPos = 10;

            foreach (var setting in generalSettings)
            {
                string name = setting["name"].ToString();
                string defaultValue = setting["default"].ToString();
                string description = setting["description"].ToString();

                Label label = new Label
                {
                    Text = description + ":",
                    Location = new Point(10, yPos),
                    AutoSize = true
                };

                TextBox textBox = new TextBox
                {
                    Name = "txt_" + name,
                    Text = defaultValue,
                    Location = new Point(200, yPos - 3),
                    Width = 300,
                    Tag = name
                };

                panelGeneralSettings.Controls.Add(label);
                panelGeneralSettings.Controls.Add(textBox);

                yPos += 30;
            }
        }

        private void LoadIW6ModSettings()
        {
            panelIW6ModSettings.Controls.Clear();
            
            var modSettings = serverData["iw6ModSettings"] as JArray;
            int yPos = 10;

            foreach (var setting in modSettings)
            {
                string name = setting["name"].ToString();
                string defaultValue = setting["default"].ToString();
                string description = setting["description"].ToString();

                Label label = new Label
                {
                    Text = description + ":",
                    Location = new Point(10, yPos),
                    AutoSize = true
                };

                TextBox textBox = new TextBox
                {
                    Name = "txt_" + name,
                    Text = defaultValue,
                    Location = new Point(200, yPos - 3),
                    Width = 300,
                    Tag = name
                };

                panelIW6ModSettings.Controls.Add(label);
                panelIW6ModSettings.Controls.Add(textBox);

                yPos += 30;
            }
        }

        private void LoadBaseGameSettings()
        {
            panelBaseGameSettings.Controls.Clear();
            
            var baseSettings = serverData["baseGameSettings"] as JArray;
            int yPos = 10;

            foreach (var setting in baseSettings)
            {
                string name = setting["name"].ToString();
                string defaultValue = setting["default"].ToString();
                string description = setting["description"].ToString();

                Label label = new Label
                {
                    Text = description + ":",
                    Location = new Point(10, yPos),
                    AutoSize = true
                };

                TextBox textBox = new TextBox
                {
                    Name = "txt_" + name,
                    Text = defaultValue,
                    Location = new Point(200, yPos - 3),
                    Width = 300,
                    Tag = name
                };

                panelBaseGameSettings.Controls.Add(label);
                panelBaseGameSettings.Controls.Add(textBox);

                yPos += 30;
            }
        }

        private void LoadGameModeSettings(string modeCode)
        {
            panelGameModeSettings.Controls.Clear();
            
            var gameModeSettings = serverData["gameModeSettings"][modeCode] as JArray;
            if (gameModeSettings == null) return;

            int yPos = 10;

            foreach (var setting in gameModeSettings)
            {
                string name = setting["name"].ToString();
                string defaultValue = setting["default"].ToString();
                string description = setting["description"].ToString();

                Label label = new Label
                {
                    Text = description + ":",
                    Location = new Point(10, yPos),
                    AutoSize = true
                };

                TextBox textBox = new TextBox
                {
                    Name = "txt_" + name,
                    Text = defaultValue,
                    Location = new Point(200, yPos - 3),
                    Width = 150,
                    Tag = name
                };

                panelGameModeSettings.Controls.Add(label);
                panelGameModeSettings.Controls.Add(textBox);

                yPos += 30;
            }
        }

        private void comboGameCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGameCategory = comboGameCategory.SelectedItem.ToString();
            LoadGameModes();
            ClearMapSelection();
            LoadAvailableMaps();
        }

        private void LoadGameModes()
        {
            comboGameMode.Items.Clear();
            
            var gameModes = serverData["gameModes"][selectedGameCategory]["modes"] as JArray;
            foreach (var mode in gameModes)
            {
                comboGameMode.Items.Add(mode["name"].ToString());
            }

            if (comboGameMode.Items.Count > 0)
            {
                comboGameMode.SelectedIndex = 0;
            }
        }

        private void comboGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGameMode.SelectedIndex < 0) return;

            string selectedModeName = comboGameMode.SelectedItem.ToString();
            var gameModes = serverData["gameModes"][selectedGameCategory]["modes"] as JArray;
            
            foreach (var mode in gameModes)
            {
                if (mode["name"].ToString() == selectedModeName)
                {
                    selectedGameMode = mode["code"].ToString();
                    break;
                }
            }

            LoadGameModeSettings(selectedGameMode);
            LoadAvailableMaps();
        }

        private void LoadAvailableMaps()
        {
            listAvailableMaps.Items.Clear();
            
            var maps = serverData["gameModes"][selectedGameCategory]["maps"] as JArray;
            foreach (var map in maps)
            {
                listAvailableMaps.Items.Add(map["name"].ToString());
            }
        }

        private void ClearMapSelection()
        {
            listAvailableMaps.Items.Clear();
            listSelectedMaps.Items.Clear();
        }

        private void btnAddMap_Click(object sender, EventArgs e)
        {
            if (listAvailableMaps.SelectedItems.Count > 0)
            {
                foreach (object item in listAvailableMaps.SelectedItems)
                {
                    listSelectedMaps.Items.Add(item.ToString());
                }
            }
        }

        private void btnRemoveMap_Click(object sender, EventArgs e)
        {
            if (listSelectedMaps.SelectedItems.Count > 0)
            {
                // Remove from highest index to lowest to avoid index issues
                var selectedIndices = listSelectedMaps.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();
                foreach (int index in selectedIndices)
                {
                    listSelectedMaps.Items.RemoveAt(index);
                }
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (listSelectedMaps.SelectedItems.Count == 0) return;
            
            // Get selected indices and sort them
            var selectedIndices = listSelectedMaps.SelectedIndices.Cast<int>().OrderBy(i => i).ToList();
            
            // Can't move up if the first selected item is already at index 0
            if (selectedIndices[0] == 0) return;
            
            // Move each selected item up one position
            listSelectedMaps.BeginUpdate();
            foreach (int index in selectedIndices)
            {
                object item = listSelectedMaps.Items[index];
                listSelectedMaps.Items.RemoveAt(index);
                listSelectedMaps.Items.Insert(index - 1, item);
                listSelectedMaps.SetSelected(index - 1, true);
            }
            listSelectedMaps.EndUpdate();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (listSelectedMaps.SelectedItems.Count == 0) return;
            
            // Get selected indices and sort them in descending order
            var selectedIndices = listSelectedMaps.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();
            
            // Can't move down if the last selected item is already at the last index
            if (selectedIndices[0] == listSelectedMaps.Items.Count - 1) return;
            
            // Move each selected item down one position
            listSelectedMaps.BeginUpdate();
            foreach (int index in selectedIndices)
            {
                object item = listSelectedMaps.Items[index];
                listSelectedMaps.Items.RemoveAt(index);
                listSelectedMaps.Items.Insert(index + 1, item);
                listSelectedMaps.SetSelected(index + 1, true);
            }
            listSelectedMaps.EndUpdate();
        }

        private void listAvailableMaps_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Ctrl+A to select all items
            if (e.Control && e.KeyCode == Keys.A)
            {
                listAvailableMaps.BeginUpdate();
                for (int i = 0; i < listAvailableMaps.Items.Count; i++)
                {
                    listAvailableMaps.SetSelected(i, true);
                }
                listAvailableMaps.EndUpdate();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void listSelectedMaps_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Ctrl+A to select all items
            if (e.Control && e.KeyCode == Keys.A)
            {
                listSelectedMaps.BeginUpdate();
                for (int i = 0; i < listSelectedMaps.Items.Count; i++)
                {
                    listSelectedMaps.SetSelected(i, true);
                }
                listSelectedMaps.EndUpdate();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFilename.Text))
            {
                MessageBox.Show("Please enter a filename.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listSelectedMaps.Items.Count == 0)
            {
                MessageBox.Show("Please select at least one map.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                GenerateConfigFile();
                MessageBox.Show("Server configuration file created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating config file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateConfigFile()
        {
            StringBuilder config = new StringBuilder();

            string filename = textFilename.Text;
            if (!filename.EndsWith(".cfg", StringComparison.OrdinalIgnoreCase))
            {
                filename += ".cfg";
            }

            string configPath = Path.Combine(Directory.GetCurrentDirectory(),"iw6", filename);

            config.AppendLine("set sv_hostname \"" + GetSettingValue("sv_hostname") + "\"");
            config.AppendLine("name \"" + GetSettingValue("name") + "\"");
            config.AppendLine();

            config.AppendLine("set _Admin \"" + GetSettingValue("_Admin") + "\"");
            config.AppendLine("set _Email \"" + GetSettingValue("_Email") + "\"");
            config.AppendLine("set _Website \"" + GetSettingValue("_Website") + "\"");
            config.AppendLine("set _Location \"" + GetSettingValue("_Location") + "\"");
            config.AppendLine();

            config.AppendLine("set sv_maxclients \"" + GetSettingValue("sv_maxclients") + "\"");
            config.AppendLine("set rcon_password \"" + GetSettingValue("rcon_password") + "\"");
            config.AppendLine("set g_password \"" + GetSettingValue("g_password") + "\"");
            config.AppendLine("set g_deadChat \"" + GetSettingValue("g_deadChat") + "\"");
            config.AppendLine("set g_inactivity \"" + GetSettingValue("g_inactivity") + "\"");
            config.AppendLine("set sv_kickBanTime \"" + GetSettingValue("sv_kickBanTime") + "\"");
            config.AppendLine("set sv_allowClientConsole \"" + GetSettingValue("sv_allowClientConsole") + "\"");
            config.AppendLine("set sv_timeout \"" + GetSettingValue("sv_timeout") + "\"");
            config.AppendLine("set sv_reconnectlimit \"" + GetSettingValue("sv_reconnectlimit") + "\"");
            config.AppendLine();

            foreach (Control control in panelIW6ModSettings.Controls)
            {
                if (control is TextBox textBox && textBox.Tag != null)
                {
                    config.AppendLine($"set {textBox.Tag} \"{textBox.Text}\"");
                }
            }
            config.AppendLine();

            foreach (Control control in panelBaseGameSettings.Controls)
            {
                if (control is TextBox textBox && textBox.Tag != null)
                {
                    config.AppendLine($"set {textBox.Tag} \"{textBox.Text}\"");
                }
            }
            config.AppendLine();

            foreach (Control control in panelGameModeSettings.Controls)
            {
                if (control is TextBox textBox && textBox.Tag != null)
                {
                    config.AppendLine($"set {textBox.Tag} \"{textBox.Text}\"");
                }
            }
            config.AppendLine();

            config.Append("set sv_maprotation \"gametype " + selectedGameMode);
            
            var maps = serverData["gameModes"][selectedGameCategory]["maps"] as JArray;
            foreach (var mapName in listSelectedMaps.Items)
            {
                foreach (var map in maps)
                {
                    if (map["name"].ToString() == mapName.ToString())
                    {
                        config.Append(" map " + map["code"].ToString());
                        break;
                    }
                }
            }
            config.AppendLine("\"");

            File.WriteAllText(configPath, config.ToString());
        }

        private string GetSettingValue(string settingName)
        {
            foreach (Control control in panelGeneralSettings.Controls)
            {
                if (control is TextBox textBox && textBox.Tag != null && textBox.Tag.ToString() == settingName)
                {
                    return textBox.Text;
                }
            }
            return "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            if (!advancedSettingsLoaded)
            {
                // Load the controls for advanced settings
                LoadIW6ModSettings();
                LoadBaseGameSettings();

                // Insert the tabs back into the tab control at their original positions
                try
                {
                    tabControl.TabPages.Insert(2, tabIW6Mod);
                    tabControl.TabPages.Insert(3, tabBaseGame);
                }
                catch
                {
                    // Fallback: ensure they are present if insertion by index fails
                    if (!tabControl.TabPages.Contains(tabIW6Mod)) tabControl.TabPages.Add(tabIW6Mod);
                    if (!tabControl.TabPages.Contains(tabBaseGame)) tabControl.TabPages.Add(tabBaseGame);
                }

                advancedSettingsLoaded = true;
                btnLoadSettings.Enabled = false;
            }
        }
    }
}
