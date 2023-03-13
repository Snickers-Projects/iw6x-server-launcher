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
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.Singleplayer = new System.Windows.Forms.Button();
            this.btnDedicated = new System.Windows.Forms.Button();
            this.textPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.checkUpdate = new System.Windows.Forms.CheckBox();
            this.checkOnline = new System.Windows.Forms.CheckBox();
            this.listBoxConfigs = new System.Windows.Forms.ListBox();
            this.labelConfigList = new System.Windows.Forms.Label();
            this.buttonPortDefault = new System.Windows.Forms.Button();
            this.labelIp = new System.Windows.Forms.Label();
            this.listBoxLocalIp = new System.Windows.Forms.ListBox();
            this.listBoxExternalIp = new System.Windows.Forms.ListBox();
            this.labelExIp = new System.Windows.Forms.Label();
            this.buttonOpenConfig = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelModeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.Location = new System.Drawing.Point(12, 12);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplayer.TabIndex = 0;
            this.btnMultiplayer.Text = "Multiplayer";
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // Singleplayer
            // 
            this.Singleplayer.Location = new System.Drawing.Point(93, 12);
            this.Singleplayer.Name = "Singleplayer";
            this.Singleplayer.Size = new System.Drawing.Size(75, 23);
            this.Singleplayer.TabIndex = 1;
            this.Singleplayer.Text = "Singleplayer";
            this.Singleplayer.UseVisualStyleBackColor = true;
            this.Singleplayer.Click += new System.EventHandler(this.Singleplayer_Click);
            // 
            // btnDedicated
            // 
            this.btnDedicated.Location = new System.Drawing.Point(12, 281);
            this.btnDedicated.Name = "btnDedicated";
            this.btnDedicated.Size = new System.Drawing.Size(86, 23);
            this.btnDedicated.TabIndex = 2;
            this.btnDedicated.Text = "Start Server";
            this.btnDedicated.UseVisualStyleBackColor = true;
            this.btnDedicated.Click += new System.EventHandler(this.btnDedicated_Click);
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(44, 159);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(70, 20);
            this.textPort.TabIndex = 3;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 162);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // checkUpdate
            // 
            this.checkUpdate.AutoSize = true;
            this.checkUpdate.Checked = true;
            this.checkUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkUpdate.Location = new System.Drawing.Point(12, 113);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(115, 17);
            this.checkUpdate.TabIndex = 5;
            this.checkUpdate.Text = "Check for Updates";
            this.checkUpdate.UseVisualStyleBackColor = true;
            // 
            // checkOnline
            // 
            this.checkOnline.AutoSize = true;
            this.checkOnline.Location = new System.Drawing.Point(12, 136);
            this.checkOnline.Name = "checkOnline";
            this.checkOnline.Size = new System.Drawing.Size(86, 17);
            this.checkOnline.TabIndex = 6;
            this.checkOnline.Text = "Online Mode";
            this.checkOnline.UseVisualStyleBackColor = true;
            this.checkOnline.CheckedChanged += new System.EventHandler(this.checkOnline_CheckedChanged);
            // 
            // listBoxConfigs
            // 
            this.listBoxConfigs.FormattingEnabled = true;
            this.listBoxConfigs.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.listBoxConfigs.Location = new System.Drawing.Point(12, 206);
            this.listBoxConfigs.Name = "listBoxConfigs";
            this.listBoxConfigs.Size = new System.Drawing.Size(167, 69);
            this.listBoxConfigs.TabIndex = 7;
            this.listBoxConfigs.SelectedIndexChanged += new System.EventHandler(this.listBoxConfigs_SelectedIndexChanged);
            // 
            // labelConfigList
            // 
            this.labelConfigList.AutoSize = true;
            this.labelConfigList.Location = new System.Drawing.Point(9, 190);
            this.labelConfigList.Name = "labelConfigList";
            this.labelConfigList.Size = new System.Drawing.Size(71, 13);
            this.labelConfigList.TabIndex = 8;
            this.labelConfigList.Text = "Server Config";
            // 
            // buttonPortDefault
            // 
            this.buttonPortDefault.Location = new System.Drawing.Point(120, 157);
            this.buttonPortDefault.Name = "buttonPortDefault";
            this.buttonPortDefault.Size = new System.Drawing.Size(49, 23);
            this.buttonPortDefault.TabIndex = 9;
            this.buttonPortDefault.Text = "Default";
            this.buttonPortDefault.UseVisualStyleBackColor = true;
            this.buttonPortDefault.Click += new System.EventHandler(this.buttonPortDefault_Click);
            // 
            // labelIp
            // 
            this.labelIp.AutoSize = true;
            this.labelIp.Location = new System.Drawing.Point(201, 58);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(52, 13);
            this.labelIp.TabIndex = 10;
            this.labelIp.Text = "Local IP: ";
            // 
            // listBoxLocalIp
            // 
            this.listBoxLocalIp.FormattingEnabled = true;
            this.listBoxLocalIp.Location = new System.Drawing.Point(259, 58);
            this.listBoxLocalIp.Name = "listBoxLocalIp";
            this.listBoxLocalIp.Size = new System.Drawing.Size(120, 30);
            this.listBoxLocalIp.TabIndex = 11;
            // 
            // listBoxExternalIp
            // 
            this.listBoxExternalIp.FormattingEnabled = true;
            this.listBoxExternalIp.Location = new System.Drawing.Point(259, 95);
            this.listBoxExternalIp.Name = "listBoxExternalIp";
            this.listBoxExternalIp.Size = new System.Drawing.Size(120, 30);
            this.listBoxExternalIp.TabIndex = 12;
            // 
            // labelExIp
            // 
            this.labelExIp.AutoSize = true;
            this.labelExIp.Location = new System.Drawing.Point(191, 95);
            this.labelExIp.Name = "labelExIp";
            this.labelExIp.Size = new System.Drawing.Size(61, 13);
            this.labelExIp.TabIndex = 13;
            this.labelExIp.Text = "External IP:";
            // 
            // buttonOpenConfig
            // 
            this.buttonOpenConfig.Location = new System.Drawing.Point(104, 281);
            this.buttonOpenConfig.Name = "buttonOpenConfig";
            this.buttonOpenConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenConfig.TabIndex = 14;
            this.buttonOpenConfig.Text = "Open Config";
            this.buttonOpenConfig.UseVisualStyleBackColor = true;
            this.buttonOpenConfig.Click += new System.EventHandler(this.buttonOpenConfig_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(86, 190);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(40, 13);
            this.labelMode.TabIndex = 15;
            this.labelMode.Text = "Mode: ";
            // 
            // labelModeText
            // 
            this.labelModeText.AutoSize = true;
            this.labelModeText.Location = new System.Drawing.Point(120, 190);
            this.labelModeText.Name = "labelModeText";
            this.labelModeText.Size = new System.Drawing.Size(57, 13);
            this.labelModeText.TabIndex = 16;
            this.labelModeText.Text = "Multiplayer";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 316);
            this.Controls.Add(this.labelModeText);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonOpenConfig);
            this.Controls.Add(this.labelExIp);
            this.Controls.Add(this.listBoxExternalIp);
            this.Controls.Add(this.listBoxLocalIp);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.buttonPortDefault);
            this.Controls.Add(this.labelConfigList);
            this.Controls.Add(this.listBoxConfigs);
            this.Controls.Add(this.checkOnline);
            this.Controls.Add(this.checkUpdate);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.btnDedicated);
            this.Controls.Add(this.Singleplayer);
            this.Controls.Add(this.btnMultiplayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IW6x - Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button Singleplayer;
        private System.Windows.Forms.Button btnDedicated;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.CheckBox checkUpdate;
        private System.Windows.Forms.CheckBox checkOnline;
        private System.Windows.Forms.ListBox listBoxConfigs;
        private System.Windows.Forms.Label labelConfigList;
        private System.Windows.Forms.Button buttonPortDefault;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.ListBox listBoxLocalIp;
        private System.Windows.Forms.ListBox listBoxExternalIp;
        private System.Windows.Forms.Label labelExIp;
        private System.Windows.Forms.Button buttonOpenConfig;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelModeText;
    }
}

