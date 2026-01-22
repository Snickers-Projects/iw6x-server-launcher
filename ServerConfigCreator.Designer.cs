namespace iw6x_server_launcher
{
    partial class ServerConfigCreator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.labelGameCategory = new System.Windows.Forms.Label();
            this.comboGameCategory = new System.Windows.Forms.ComboBox();
            this.labelGameMode = new System.Windows.Forms.Label();
            this.comboGameMode = new System.Windows.Forms.ComboBox();
            this.labelFilename = new System.Windows.Forms.Label();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.panelGeneralSettings = new System.Windows.Forms.Panel();
            this.tabIW6Mod = new System.Windows.Forms.TabPage();
            this.panelIW6ModSettings = new System.Windows.Forms.Panel();
            this.tabBaseGame = new System.Windows.Forms.TabPage();
            this.panelBaseGameSettings = new System.Windows.Forms.Panel();
            this.tabGameMode = new System.Windows.Forms.TabPage();
            this.panelGameModeSettings = new System.Windows.Forms.Panel();
            this.tabMapRotation = new System.Windows.Forms.TabPage();
            this.labelAvailableMaps = new System.Windows.Forms.Label();
            this.listAvailableMaps = new System.Windows.Forms.ListBox();
            this.btnAddMap = new System.Windows.Forms.Button();
            this.btnRemoveMap = new System.Windows.Forms.Button();
            this.labelSelectedMaps = new System.Windows.Forms.Label();
            this.listSelectedMaps = new System.Windows.Forms.ListBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBasic.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabIW6Mod.SuspendLayout();
            this.tabBaseGame.SuspendLayout();
            this.tabGameMode.SuspendLayout();
            this.tabMapRotation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBasic);
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabIW6Mod);
            this.tabControl.Controls.Add(this.tabBaseGame);
            this.tabControl.Controls.Add(this.tabGameMode);
            this.tabControl.Controls.Add(this.tabMapRotation);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 500);
            this.tabControl.TabIndex = 0;
            // 
            // tabBasic
            // 
            this.tabBasic.Controls.Add(this.labelGameCategory);
            this.tabBasic.Controls.Add(this.comboGameCategory);
            this.tabBasic.Controls.Add(this.labelGameMode);
            this.tabBasic.Controls.Add(this.comboGameMode);
            this.tabBasic.Controls.Add(this.labelFilename);
            this.tabBasic.Controls.Add(this.textFilename);
            this.tabBasic.Controls.Add(this.btnLoadSettings);
            this.tabBasic.Location = new System.Drawing.Point(4, 22);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasic.Size = new System.Drawing.Size(752, 474);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic";
            this.tabBasic.UseVisualStyleBackColor = true;
            // 
            // labelGameCategory
            // 
            this.labelGameCategory.AutoSize = true;
            this.labelGameCategory.Location = new System.Drawing.Point(20, 20);
            this.labelGameCategory.Name = "labelGameCategory";
            this.labelGameCategory.Size = new System.Drawing.Size(85, 13);
            this.labelGameCategory.TabIndex = 0;
            this.labelGameCategory.Text = "Game Category:";
            // 
            // comboGameCategory
            // 
            this.comboGameCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGameCategory.FormattingEnabled = true;
            this.comboGameCategory.Location = new System.Drawing.Point(140, 17);
            this.comboGameCategory.Name = "comboGameCategory";
            this.comboGameCategory.Size = new System.Drawing.Size(200, 21);
            this.comboGameCategory.TabIndex = 1;
            this.comboGameCategory.SelectedIndexChanged += new System.EventHandler(this.comboGameCategory_SelectedIndexChanged);
            // 
            // labelGameMode
            // 
            this.labelGameMode.AutoSize = true;
            this.labelGameMode.Location = new System.Drawing.Point(20, 60);
            this.labelGameMode.Name = "labelGameMode";
            this.labelGameMode.Size = new System.Drawing.Size(68, 13);
            this.labelGameMode.TabIndex = 2;
            this.labelGameMode.Text = "Game Mode:";
            // 
            // comboGameMode
            // 
            this.comboGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGameMode.FormattingEnabled = true;
            this.comboGameMode.Location = new System.Drawing.Point(140, 57);
            this.comboGameMode.Name = "comboGameMode";
            this.comboGameMode.Size = new System.Drawing.Size(200, 21);
            this.comboGameMode.TabIndex = 3;
            this.comboGameMode.SelectedIndexChanged += new System.EventHandler(this.comboGameMode_SelectedIndexChanged);
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(20, 100);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(52, 13);
            this.labelFilename.TabIndex = 4;
            this.labelFilename.Text = "Filename:";
            // 
            // textFilename
            // 
            this.textFilename.Location = new System.Drawing.Point(140, 97);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(300, 20);
            this.textFilename.TabIndex = 5;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(140, 140);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(200, 30);
            this.btnLoadSettings.TabIndex = 6;
            this.btnLoadSettings.Text = "Load Advanced Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // tabGeneral
            // 
            this.tabGeneral.AutoScroll = true;
            this.tabGeneral.Controls.Add(this.panelGeneralSettings);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(752, 474);
            this.tabGeneral.TabIndex = 1;
            this.tabGeneral.Text = "General Settings";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // panelGeneralSettings
            // 
            this.panelGeneralSettings.AutoScroll = true;
            this.panelGeneralSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGeneralSettings.Location = new System.Drawing.Point(3, 3);
            this.panelGeneralSettings.Name = "panelGeneralSettings";
            this.panelGeneralSettings.Size = new System.Drawing.Size(746, 468);
            this.panelGeneralSettings.TabIndex = 0;
            // 
            // tabIW6Mod
            // 
            this.tabIW6Mod.AutoScroll = true;
            this.tabIW6Mod.Controls.Add(this.panelIW6ModSettings);
            this.tabIW6Mod.Location = new System.Drawing.Point(4, 22);
            this.tabIW6Mod.Name = "tabIW6Mod";
            this.tabIW6Mod.Size = new System.Drawing.Size(752, 474);
            this.tabIW6Mod.TabIndex = 2;
            this.tabIW6Mod.Text = "IW6 Mod Settings";
            this.tabIW6Mod.UseVisualStyleBackColor = true;
            // 
            // panelIW6ModSettings
            // 
            this.panelIW6ModSettings.AutoScroll = true;
            this.panelIW6ModSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIW6ModSettings.Location = new System.Drawing.Point(0, 0);
            this.panelIW6ModSettings.Name = "panelIW6ModSettings";
            this.panelIW6ModSettings.Size = new System.Drawing.Size(752, 474);
            this.panelIW6ModSettings.TabIndex = 0;
            // 
            // tabBaseGame
            // 
            this.tabBaseGame.AutoScroll = true;
            this.tabBaseGame.Controls.Add(this.panelBaseGameSettings);
            this.tabBaseGame.Location = new System.Drawing.Point(4, 22);
            this.tabBaseGame.Name = "tabBaseGame";
            this.tabBaseGame.Size = new System.Drawing.Size(752, 474);
            this.tabBaseGame.TabIndex = 3;
            this.tabBaseGame.Text = "Base Game Settings";
            this.tabBaseGame.UseVisualStyleBackColor = true;
            // 
            // panelBaseGameSettings
            // 
            this.panelBaseGameSettings.AutoScroll = true;
            this.panelBaseGameSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaseGameSettings.Location = new System.Drawing.Point(0, 0);
            this.panelBaseGameSettings.Name = "panelBaseGameSettings";
            this.panelBaseGameSettings.Size = new System.Drawing.Size(752, 474);
            this.panelBaseGameSettings.TabIndex = 0;
            // 
            // tabGameMode
            // 
            this.tabGameMode.AutoScroll = true;
            this.tabGameMode.Controls.Add(this.panelGameModeSettings);
            this.tabGameMode.Location = new System.Drawing.Point(4, 22);
            this.tabGameMode.Name = "tabGameMode";
            this.tabGameMode.Size = new System.Drawing.Size(752, 474);
            this.tabGameMode.TabIndex = 4;
            this.tabGameMode.Text = "Game Mode Settings";
            this.tabGameMode.UseVisualStyleBackColor = true;
            // 
            // panelGameModeSettings
            // 
            this.panelGameModeSettings.AutoScroll = true;
            this.panelGameModeSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameModeSettings.Location = new System.Drawing.Point(0, 0);
            this.panelGameModeSettings.Name = "panelGameModeSettings";
            this.panelGameModeSettings.Size = new System.Drawing.Size(752, 474);
            this.panelGameModeSettings.TabIndex = 0;
            // 
            // tabMapRotation
            // 
            this.tabMapRotation.Controls.Add(this.labelAvailableMaps);
            this.tabMapRotation.Controls.Add(this.listAvailableMaps);
            this.tabMapRotation.Controls.Add(this.btnAddMap);
            this.tabMapRotation.Controls.Add(this.btnRemoveMap);
            this.tabMapRotation.Controls.Add(this.labelSelectedMaps);
            this.tabMapRotation.Controls.Add(this.listSelectedMaps);
            this.tabMapRotation.Controls.Add(this.btnMoveUp);
            this.tabMapRotation.Controls.Add(this.btnMoveDown);
            this.tabMapRotation.Location = new System.Drawing.Point(4, 22);
            this.tabMapRotation.Name = "tabMapRotation";
            this.tabMapRotation.Size = new System.Drawing.Size(752, 474);
            this.tabMapRotation.TabIndex = 5;
            this.tabMapRotation.Text = "Map Rotation";
            this.tabMapRotation.UseVisualStyleBackColor = true;
            // 
            // labelAvailableMaps
            // 
            this.labelAvailableMaps.AutoSize = true;
            this.labelAvailableMaps.Location = new System.Drawing.Point(20, 20);
            this.labelAvailableMaps.Name = "labelAvailableMaps";
            this.labelAvailableMaps.Size = new System.Drawing.Size(82, 13);
            this.labelAvailableMaps.TabIndex = 0;
            this.labelAvailableMaps.Text = "Available Maps:";
            // 
            // listAvailableMaps
            // 
            this.listAvailableMaps.FormattingEnabled = true;
            this.listAvailableMaps.Location = new System.Drawing.Point(20, 40);
            this.listAvailableMaps.Name = "listAvailableMaps";
            this.listAvailableMaps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listAvailableMaps.Size = new System.Drawing.Size(250, 381);
            this.listAvailableMaps.TabIndex = 1;
            this.listAvailableMaps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listAvailableMaps_KeyDown);
            // 
            // btnAddMap
            // 
            this.btnAddMap.Location = new System.Drawing.Point(290, 150);
            this.btnAddMap.Name = "btnAddMap";
            this.btnAddMap.Size = new System.Drawing.Size(80, 30);
            this.btnAddMap.TabIndex = 2;
            this.btnAddMap.Text = "Add >>";
            this.btnAddMap.UseVisualStyleBackColor = true;
            this.btnAddMap.Click += new System.EventHandler(this.btnAddMap_Click);
            // 
            // btnRemoveMap
            // 
            this.btnRemoveMap.Location = new System.Drawing.Point(290, 200);
            this.btnRemoveMap.Name = "btnRemoveMap";
            this.btnRemoveMap.Size = new System.Drawing.Size(80, 30);
            this.btnRemoveMap.TabIndex = 3;
            this.btnRemoveMap.Text = "<< Remove";
            this.btnRemoveMap.UseVisualStyleBackColor = true;
            this.btnRemoveMap.Click += new System.EventHandler(this.btnRemoveMap_Click);
            // 
            // labelSelectedMaps
            // 
            this.labelSelectedMaps.AutoSize = true;
            this.labelSelectedMaps.Location = new System.Drawing.Point(390, 20);
            this.labelSelectedMaps.Name = "labelSelectedMaps";
            this.labelSelectedMaps.Size = new System.Drawing.Size(82, 13);
            this.labelSelectedMaps.TabIndex = 4;
            this.labelSelectedMaps.Text = "Selected Maps:";
            // 
            // listSelectedMaps
            // 
            this.listSelectedMaps.FormattingEnabled = true;
            this.listSelectedMaps.Location = new System.Drawing.Point(390, 40);
            this.listSelectedMaps.Name = "listSelectedMaps";
            this.listSelectedMaps.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listSelectedMaps.Size = new System.Drawing.Size(250, 381);
            this.listSelectedMaps.TabIndex = 5;
            this.listSelectedMaps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listSelectedMaps_KeyDown);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(655, 150);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(80, 30);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Location = new System.Drawing.Point(655, 200);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(80, 30);
            this.btnMoveDown.TabIndex = 7;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(586, 518);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 30);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Config";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(682, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ServerConfigCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerConfigCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Server Config Creator";
            this.tabControl.ResumeLayout(false);
            this.tabBasic.ResumeLayout(false);
            this.tabBasic.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabIW6Mod.ResumeLayout(false);
            this.tabBaseGame.ResumeLayout(false);
            this.tabGameMode.ResumeLayout(false);
            this.tabMapRotation.ResumeLayout(false);
            this.tabMapRotation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBasic;
        private System.Windows.Forms.Label labelGameCategory;
        private System.Windows.Forms.ComboBox comboGameCategory;
        private System.Windows.Forms.Label labelGameMode;
        private System.Windows.Forms.ComboBox comboGameMode;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Panel panelGeneralSettings;
        private System.Windows.Forms.TabPage tabIW6Mod;
        private System.Windows.Forms.Panel panelIW6ModSettings;
        private System.Windows.Forms.TabPage tabBaseGame;
        private System.Windows.Forms.Panel panelBaseGameSettings;
        private System.Windows.Forms.TabPage tabGameMode;
        private System.Windows.Forms.Panel panelGameModeSettings;
        private System.Windows.Forms.TabPage tabMapRotation;
        private System.Windows.Forms.Label labelAvailableMaps;
        private System.Windows.Forms.ListBox listAvailableMaps;
        private System.Windows.Forms.Button btnAddMap;
        private System.Windows.Forms.Button btnRemoveMap;
        private System.Windows.Forms.Label labelSelectedMaps;
        private System.Windows.Forms.ListBox listSelectedMaps;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}
