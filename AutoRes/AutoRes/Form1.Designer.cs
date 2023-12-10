namespace AutoRes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GameDropDown = new ComboBox();
            Game = new Label();
            FileToReadOnlyCheckBox = new CheckBox();
            ApexResolutionDropDown = new ComboBox();
            SetSettingsButton = new Button();
            CustomResolutionCheckBox = new CheckBox();
            CustomWidthTextBox = new TextBox();
            CustomHeightTextBox = new TextBox();
            CustomHeightLabel = new Label();
            CustomWidthLabel = new Label();
            FPSLimitTextBox = new TextBox();
            FPSLimitLabel = new Label();
            ResolutionAndFpsOnlyCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // GameDropDown
            // 
            GameDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            GameDropDown.FormattingEnabled = true;
            GameDropDown.Location = new Point(81, 27);
            GameDropDown.Name = "GameDropDown";
            GameDropDown.Size = new Size(121, 23);
            GameDropDown.TabIndex = 0;
            GameDropDown.SelectedIndexChanged += GameDropDown_SelectedIndexChanged;
            // 
            // Game
            // 
            Game.AutoSize = true;
            Game.Location = new Point(121, 9);
            Game.Name = "Game";
            Game.Size = new Size(38, 15);
            Game.TabIndex = 1;
            Game.Text = "Game";
            // 
            // FileToReadOnlyCheckBox
            // 
            FileToReadOnlyCheckBox.AutoSize = true;
            FileToReadOnlyCheckBox.Location = new Point(10, 208);
            FileToReadOnlyCheckBox.Name = "FileToReadOnlyCheckBox";
            FileToReadOnlyCheckBox.Size = new Size(135, 19);
            FileToReadOnlyCheckBox.TabIndex = 2;
            FileToReadOnlyCheckBox.Text = "Set File To Read Only";
            FileToReadOnlyCheckBox.UseVisualStyleBackColor = true;
            FileToReadOnlyCheckBox.CheckedChanged += FileToReadOnlyCheckBox_CheckedChanged;
            // 
            // ApexResolutionDropDown
            // 
            ApexResolutionDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            ApexResolutionDropDown.FormattingEnabled = true;
            ApexResolutionDropDown.Location = new Point(81, 80);
            ApexResolutionDropDown.Name = "ApexResolutionDropDown";
            ApexResolutionDropDown.Size = new Size(121, 23);
            ApexResolutionDropDown.TabIndex = 3;
            ApexResolutionDropDown.SelectedIndexChanged += ApexResolutionDropDown_SelectedIndexChanged;
            // 
            // SetSettingsButton
            // 
            SetSettingsButton.Location = new Point(102, 153);
            SetSettingsButton.Name = "SetSettingsButton";
            SetSettingsButton.Size = new Size(96, 23);
            SetSettingsButton.TabIndex = 4;
            SetSettingsButton.Text = "Set Settings";
            SetSettingsButton.UseVisualStyleBackColor = true;
            SetSettingsButton.Click += SetSettingsButton_Click;
            // 
            // CustomResolutionCheckBox
            // 
            CustomResolutionCheckBox.AutoSize = true;
            CustomResolutionCheckBox.Location = new Point(10, 180);
            CustomResolutionCheckBox.Name = "CustomResolutionCheckBox";
            CustomResolutionCheckBox.Size = new Size(127, 19);
            CustomResolutionCheckBox.TabIndex = 5;
            CustomResolutionCheckBox.Text = "Custom Resolution";
            CustomResolutionCheckBox.UseVisualStyleBackColor = true;
            CustomResolutionCheckBox.CheckedChanged += CustomResolutionCheckBox_CheckedChanged;
            // 
            // CustomWidthTextBox
            // 
            CustomWidthTextBox.Location = new Point(45, 80);
            CustomWidthTextBox.Name = "CustomWidthTextBox";
            CustomWidthTextBox.Size = new Size(100, 23);
            CustomWidthTextBox.TabIndex = 6;
            // 
            // CustomHeightTextBox
            // 
            CustomHeightTextBox.Location = new Point(151, 80);
            CustomHeightTextBox.Name = "CustomHeightTextBox";
            CustomHeightTextBox.Size = new Size(100, 23);
            CustomHeightTextBox.TabIndex = 7;
            // 
            // CustomHeightLabel
            // 
            CustomHeightLabel.AutoSize = true;
            CustomHeightLabel.Location = new Point(173, 62);
            CustomHeightLabel.Name = "CustomHeightLabel";
            CustomHeightLabel.Size = new Size(43, 15);
            CustomHeightLabel.TabIndex = 9;
            CustomHeightLabel.Text = "Height";
            // 
            // CustomWidthLabel
            // 
            CustomWidthLabel.AutoSize = true;
            CustomWidthLabel.Location = new Point(71, 62);
            CustomWidthLabel.Name = "CustomWidthLabel";
            CustomWidthLabel.Size = new Size(39, 15);
            CustomWidthLabel.TabIndex = 10;
            CustomWidthLabel.Text = "Width";
            // 
            // FPSLimitTextBox
            // 
            FPSLimitTextBox.Location = new Point(102, 124);
            FPSLimitTextBox.Name = "FPSLimitTextBox";
            FPSLimitTextBox.Size = new Size(100, 23);
            FPSLimitTextBox.TabIndex = 11;
            // 
            // FPSLimitLabel
            // 
            FPSLimitLabel.AutoSize = true;
            FPSLimitLabel.Location = new Point(121, 106);
            FPSLimitLabel.Name = "FPSLimitLabel";
            FPSLimitLabel.Size = new Size(56, 15);
            FPSLimitLabel.TabIndex = 12;
            FPSLimitLabel.Text = "FPS Limit";
            // 
            // ResolutionAndFpsOnlyCheckBox
            // 
            ResolutionAndFpsOnlyCheckBox.AutoSize = true;
            ResolutionAndFpsOnlyCheckBox.Location = new Point(10, 180);
            ResolutionAndFpsOnlyCheckBox.Name = "ResolutionAndFpsOnlyCheckBox";
            ResolutionAndFpsOnlyCheckBox.Size = new Size(221, 19);
            ResolutionAndFpsOnlyCheckBox.TabIndex = 13;
            ResolutionAndFpsOnlyCheckBox.Text = "Change only resolution and FPS limit";
            ResolutionAndFpsOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 239);
            Controls.Add(ResolutionAndFpsOnlyCheckBox);
            Controls.Add(FPSLimitLabel);
            Controls.Add(FPSLimitTextBox);
            Controls.Add(CustomWidthLabel);
            Controls.Add(CustomHeightLabel);
            Controls.Add(CustomHeightTextBox);
            Controls.Add(CustomWidthTextBox);
            Controls.Add(CustomResolutionCheckBox);
            Controls.Add(SetSettingsButton);
            Controls.Add(ApexResolutionDropDown);
            Controls.Add(FileToReadOnlyCheckBox);
            Controls.Add(Game);
            Controls.Add(GameDropDown);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "AutoRes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox GameDropDown;
        private Label Game;
        private CheckBox FileToReadOnlyCheckBox;
        private ComboBox ApexResolutionDropDown;
        private Button SetSettingsButton;
        private CheckBox CustomResolutionCheckBox;
        private TextBox CustomWidthTextBox;
        private TextBox CustomHeightTextBox;
        private Label CustomHeightLabel;
        private Label CustomWidthLabel;
        private TextBox FPSLimitTextBox;
        private Label FPSLimitLabel;
        private CheckBox ResolutionAndFpsOnlyCheckBox;
    }
}
