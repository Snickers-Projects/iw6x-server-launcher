namespace iw6x_server_launcher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnDedicated = new System.Windows.Forms.Button();
            this.textPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.checkUpdate = new System.Windows.Forms.CheckBox();
            this.checkOnline = new System.Windows.Forms.CheckBox();
            this.listBoxConfigs = new System.Windows.Forms.ListBox();
            this.labelConfigList = new System.Windows.Forms.Label();
            this.buttonPortDefault = new System.Windows.Forms.Button();
            this.buttonOpenConfig = new System.Windows.Forms.Button();
            this.listBoxExternalIp = new System.Windows.Forms.ListBox();
            this.labelExIp = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.Singleplayer = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.listBoxLocalIp = new System.Windows.Forms.ListBox();
            this.buttonLocalConnect = new System.Windows.Forms.Button();
            this.textBoxDirectConnect = new System.Windows.Forms.TextBox();
            this.labelDirectConnect = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.tabHost = new System.Windows.Forms.TabPage();
            this.labelPlayersValue = new System.Windows.Forms.Label();
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelGameModeValue = new System.Windows.Forms.Label();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.checkBoxMapRandom = new System.Windows.Forms.CheckBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.labelVersion = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tabHost.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDedicated
            // 
            this.btnDedicated.BackColor = System.Drawing.Color.White;
            this.btnDedicated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDedicated.Location = new System.Drawing.Point(232, 256);
            this.btnDedicated.Name = "btnDedicated";
            this.btnDedicated.Size = new System.Drawing.Size(102, 23);
            this.btnDedicated.TabIndex = 2;
            this.btnDedicated.Text = "Start Server";
            this.btnDedicated.UseVisualStyleBackColor = false;
            this.btnDedicated.Click += new System.EventHandler(this.btnDedicated_Click);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(37, 259);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(73, 20);
            this.textPort.TabIndex = 3;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.BackColor = System.Drawing.Color.Transparent;
            this.labelPort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPort.Location = new System.Drawing.Point(5, 262);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // checkUpdate
            // 
            this.checkUpdate.AutoSize = true;
            this.checkUpdate.BackColor = System.Drawing.Color.Transparent;
            this.checkUpdate.Checked = true;
            this.checkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkUpdate.Location = new System.Drawing.Point(8, 284);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(115, 17);
            this.checkUpdate.TabIndex = 5;
            this.checkUpdate.Text = "Check for Updates";
            this.checkUpdate.UseVisualStyleBackColor = false;
            // 
            // checkOnline
            // 
            this.checkOnline.AutoSize = true;
            this.checkOnline.BackColor = System.Drawing.Color.Transparent;
            this.checkOnline.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkOnline.Location = new System.Drawing.Point(129, 284);
            this.checkOnline.Name = "checkOnline";
            this.checkOnline.Size = new System.Drawing.Size(86, 17);
            this.checkOnline.TabIndex = 6;
            this.checkOnline.Text = "Online Mode";
            this.checkOnline.UseVisualStyleBackColor = false;
            this.checkOnline.CheckedChanged += new System.EventHandler(this.checkOnline_CheckedChanged);
            // 
            // listBoxConfigs
            // 
            this.listBoxConfigs.FormattingEnabled = true;
            this.listBoxConfigs.Location = new System.Drawing.Point(6, 23);
            this.listBoxConfigs.Name = "listBoxConfigs";
            this.listBoxConfigs.Size = new System.Drawing.Size(328, 69);
            this.listBoxConfigs.TabIndex = 7;
            this.listBoxConfigs.SelectedIndexChanged += new System.EventHandler(this.listBoxConfigs_SelectedIndexChanged);
            // 
            // labelConfigList
            // 
            this.labelConfigList.AutoSize = true;
            this.labelConfigList.BackColor = System.Drawing.Color.Transparent;
            this.labelConfigList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelConfigList.Location = new System.Drawing.Point(3, 7);
            this.labelConfigList.Name = "labelConfigList";
            this.labelConfigList.Size = new System.Drawing.Size(71, 13);
            this.labelConfigList.TabIndex = 8;
            this.labelConfigList.Text = "Server Config";
            // 
            // buttonPortDefault
            // 
            this.buttonPortDefault.BackColor = System.Drawing.Color.White;
            this.buttonPortDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPortDefault.Location = new System.Drawing.Point(116, 257);
            this.buttonPortDefault.Name = "buttonPortDefault";
            this.buttonPortDefault.Size = new System.Drawing.Size(56, 23);
            this.buttonPortDefault.TabIndex = 9;
            this.buttonPortDefault.Text = "Default";
            this.buttonPortDefault.UseVisualStyleBackColor = false;
            this.buttonPortDefault.Click += new System.EventHandler(this.buttonPortDefault_Click);
            // 
            // buttonOpenConfig
            // 
            this.buttonOpenConfig.BackColor = System.Drawing.Color.White;
            this.buttonOpenConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenConfig.Location = new System.Drawing.Point(255, 98);
            this.buttonOpenConfig.Name = "buttonOpenConfig";
            this.buttonOpenConfig.Size = new System.Drawing.Size(79, 24);
            this.buttonOpenConfig.TabIndex = 14;
            this.buttonOpenConfig.Text = "Open Config";
            this.buttonOpenConfig.UseVisualStyleBackColor = false;
            this.buttonOpenConfig.Click += new System.EventHandler(this.buttonOpenConfig_Click);
            // 
            // listBoxExternalIp
            // 
            this.listBoxExternalIp.FormattingEnabled = true;
            this.listBoxExternalIp.Location = new System.Drawing.Point(17, 82);
            this.listBoxExternalIp.Name = "listBoxExternalIp";
            this.listBoxExternalIp.Size = new System.Drawing.Size(120, 30);
            this.listBoxExternalIp.TabIndex = 12;
            // 
            // labelExIp
            // 
            this.labelExIp.AutoSize = true;
            this.labelExIp.BackColor = System.Drawing.Color.Transparent;
            this.labelExIp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelExIp.Location = new System.Drawing.Point(14, 66);
            this.labelExIp.Name = "labelExIp";
            this.labelExIp.Size = new System.Drawing.Size(61, 13);
            this.labelExIp.TabIndex = 13;
            this.labelExIp.Text = "External IP:";
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.BackColor = System.Drawing.Color.Transparent;
            this.labelIp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIp.Location = new System.Drawing.Point(14, 15);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(52, 13);
            this.labelIp.TabIndex = 10;
            this.labelIp.Text = "Local IP: ";
            // 
            // Singleplayer
            // 
            this.Singleplayer.BackColor = System.Drawing.Color.White;
            this.Singleplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Singleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Singleplayer.Location = new System.Drawing.Point(171, 6);
            this.Singleplayer.Name = "Singleplayer";
            this.Singleplayer.Size = new System.Drawing.Size(155, 29);
            this.Singleplayer.TabIndex = 1;
            this.Singleplayer.Text = "Singleplayer";
            this.Singleplayer.UseVisualStyleBackColor = false;
            this.Singleplayer.Click += new System.EventHandler(this.Singleplayer_Click);
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.BackColor = System.Drawing.Color.White;
            this.btnMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayer.Location = new System.Drawing.Point(10, 6);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(155, 30);
            this.btnMultiplayer.TabIndex = 0;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = false;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // listBoxLocalIp
            // 
            this.listBoxLocalIp.FormattingEnabled = true;
            this.listBoxLocalIp.Location = new System.Drawing.Point(17, 33);
            this.listBoxLocalIp.Name = "listBoxLocalIp";
            this.listBoxLocalIp.Size = new System.Drawing.Size(120, 30);
            this.listBoxLocalIp.TabIndex = 11;
            // 
            // buttonLocalConnect
            // 
            this.buttonLocalConnect.Location = new System.Drawing.Point(171, 76);
            this.buttonLocalConnect.Name = "buttonLocalConnect";
            this.buttonLocalConnect.Size = new System.Drawing.Size(155, 21);
            this.buttonLocalConnect.TabIndex = 17;
            this.buttonLocalConnect.Text = "Connect";
            this.buttonLocalConnect.UseVisualStyleBackColor = true;
            this.buttonLocalConnect.Click += new System.EventHandler(this.buttonLocalConnect_Click);
            // 
            // textBoxDirectConnect
            // 
            this.textBoxDirectConnect.Location = new System.Drawing.Point(10, 76);
            this.textBoxDirectConnect.Name = "textBoxDirectConnect";
            this.textBoxDirectConnect.Size = new System.Drawing.Size(155, 20);
            this.textBoxDirectConnect.TabIndex = 18;
            // 
            // labelDirectConnect
            // 
            this.labelDirectConnect.AutoSize = true;
            this.labelDirectConnect.BackColor = System.Drawing.Color.Transparent;
            this.labelDirectConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDirectConnect.Location = new System.Drawing.Point(7, 60);
            this.labelDirectConnect.Name = "labelDirectConnect";
            this.labelDirectConnect.Size = new System.Drawing.Size(78, 13);
            this.labelDirectConnect.TabIndex = 19;
            this.labelDirectConnect.Text = "Direct Connect";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClient);
            this.tabControl1.Controls.Add(this.tabHost);
            this.tabControl1.Controls.Add(this.tabInfo);
            this.tabControl1.Location = new System.Drawing.Point(23, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 333);
            this.tabControl1.TabIndex = 20;
            // 
            // tabClient
            // 
            this.tabClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.tabClient.Controls.Add(this.btnMultiplayer);
            this.tabClient.Controls.Add(this.labelDirectConnect);
            this.tabClient.Controls.Add(this.Singleplayer);
            this.tabClient.Controls.Add(this.textBoxDirectConnect);
            this.tabClient.Controls.Add(this.buttonLocalConnect);
            this.tabClient.Location = new System.Drawing.Point(4, 22);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(340, 307);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Client";
            // 
            // tabHost
            // 
            this.tabHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.tabHost.Controls.Add(this.labelPlayersValue);
            this.tabHost.Controls.Add(this.labelPlayers);
            this.tabHost.Controls.Add(this.labelGameModeValue);
            this.tabHost.Controls.Add(this.labelGameMode);
            this.tabHost.Controls.Add(this.checkBoxMapRandom);
            this.tabHost.Controls.Add(this.checkUpdate);
            this.tabHost.Controls.Add(this.btnDedicated);
            this.tabHost.Controls.Add(this.textPort);
            this.tabHost.Controls.Add(this.buttonOpenConfig);
            this.tabHost.Controls.Add(this.labelPort);
            this.tabHost.Controls.Add(this.buttonPortDefault);
            this.tabHost.Controls.Add(this.checkOnline);
            this.tabHost.Controls.Add(this.labelConfigList);
            this.tabHost.Controls.Add(this.listBoxConfigs);
            this.tabHost.Location = new System.Drawing.Point(4, 22);
            this.tabHost.Name = "tabHost";
            this.tabHost.Padding = new System.Windows.Forms.Padding(3);
            this.tabHost.Size = new System.Drawing.Size(340, 307);
            this.tabHost.TabIndex = 1;
            this.tabHost.Text = "Host";
            // 
            // labelPlayersValue
            // 
            this.labelPlayersValue.AutoSize = true;
            this.labelPlayersValue.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayersValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPlayersValue.Location = new System.Drawing.Point(94, 126);
            this.labelPlayersValue.Name = "labelPlayersValue";
            this.labelPlayersValue.Size = new System.Drawing.Size(53, 13);
            this.labelPlayersValue.TabIndex = 21;
            this.labelPlayersValue.Text = "Unknown";
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPlayers.Location = new System.Drawing.Point(46, 126);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(47, 13);
            this.labelPlayers.TabIndex = 20;
            this.labelPlayers.Text = "Players: ";
            // 
            // labelGameModeValue
            // 
            this.labelGameModeValue.AutoSize = true;
            this.labelGameModeValue.BackColor = System.Drawing.Color.Transparent;
            this.labelGameModeValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGameModeValue.Location = new System.Drawing.Point(94, 104);
            this.labelGameModeValue.Name = "labelGameModeValue";
            this.labelGameModeValue.Size = new System.Drawing.Size(53, 13);
            this.labelGameModeValue.TabIndex = 19;
            this.labelGameModeValue.Text = "Unknown";
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.BackColor = System.Drawing.Color.Transparent;
            this.labelGameMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGameMode.Location = new System.Drawing.Point(6, 104);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(87, 13);
            this.labelGameMode.TabIndex = 18;
            this.labelGameMode.Text = "Detected Mode: ";
            // 
            // checkBoxMapRandom
            // 
            this.checkBoxMapRandom.AutoSize = true;
            this.checkBoxMapRandom.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMapRandom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxMapRandom.Location = new System.Drawing.Point(6, 162);
            this.checkBoxMapRandom.Name = "checkBoxMapRandom";
            this.checkBoxMapRandom.Size = new System.Drawing.Size(164, 17);
            this.checkBoxMapRandom.TabIndex = 17;
            this.checkBoxMapRandom.Text = "Try Randomize Map Rotation";
            this.checkBoxMapRandom.UseVisualStyleBackColor = false;
            this.checkBoxMapRandom.CheckedChanged += new System.EventHandler(this.checkBoxMapRandom_CheckedChanged);
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.tabInfo.Controls.Add(this.labelVersion);
            this.tabInfo.Controls.Add(this.listBoxExternalIp);
            this.tabInfo.Controls.Add(this.listBoxLocalIp);
            this.tabInfo.Controls.Add(this.labelIp);
            this.tabInfo.Controls.Add(this.labelExIp);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(340, 307);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVersion.Location = new System.Drawing.Point(272, 284);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(63, 13);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "Version: 0.1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::iw6x_server_launcher.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(395, 484);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IW6x - Launcher";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            this.tabHost.ResumeLayout(false);
            this.tabHost.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDedicated;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.CheckBox checkUpdate;
        private System.Windows.Forms.CheckBox checkOnline;
        private System.Windows.Forms.ListBox listBoxConfigs;
        private System.Windows.Forms.Label labelConfigList;
        private System.Windows.Forms.Button buttonPortDefault;
        private System.Windows.Forms.Button buttonOpenConfig;
        private System.Windows.Forms.ListBox listBoxExternalIp;
        private System.Windows.Forms.Label labelExIp;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.Button Singleplayer;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.ListBox listBoxLocalIp;
        private System.Windows.Forms.Button buttonLocalConnect;
        private System.Windows.Forms.TextBox textBoxDirectConnect;
        private System.Windows.Forms.Label labelDirectConnect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabHost;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.CheckBox checkBoxMapRandom;
        private System.Windows.Forms.Label labelGameModeValue;
        private System.Windows.Forms.Label labelGameMode;
        private System.Windows.Forms.Label labelPlayersValue;
        private System.Windows.Forms.Label labelPlayers;
    }
}

