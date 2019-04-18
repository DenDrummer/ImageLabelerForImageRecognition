namespace ImageLabelerForImageRecognition
{
    partial class ImageLabelerForm
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.GameGroupBox = new System.Windows.Forms.GroupBox();
            this.StreetFighter2RadioButton = new System.Windows.Forms.RadioButton();
            this.MortalKombatRadioButton = new System.Windows.Forms.RadioButton();
            this.nextImageButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.CharacterGroupBox = new System.Windows.Forms.GroupBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.PlayerOneComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerTwoComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerTwoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.GameGroupBox.SuspendLayout();
            this.CharacterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.Location = new System.Drawing.Point(12, 28);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(960, 449);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // GameGroupBox
            // 
            this.GameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameGroupBox.Controls.Add(this.StreetFighter2RadioButton);
            this.GameGroupBox.Controls.Add(this.MortalKombatRadioButton);
            this.GameGroupBox.Location = new System.Drawing.Point(12, 483);
            this.GameGroupBox.Name = "GameGroupBox";
            this.GameGroupBox.Size = new System.Drawing.Size(116, 166);
            this.GameGroupBox.TabIndex = 1;
            this.GameGroupBox.TabStop = false;
            this.GameGroupBox.Text = "Game";
            // 
            // StreetFighter2RadioButton
            // 
            this.StreetFighter2RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetFighter2RadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.StreetFighter2RadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StreetFighter2RadioButton.Location = new System.Drawing.Point(6, 49);
            this.StreetFighter2RadioButton.Name = "StreetFighter2RadioButton";
            this.StreetFighter2RadioButton.Size = new System.Drawing.Size(104, 24);
            this.StreetFighter2RadioButton.TabIndex = 1;
            this.StreetFighter2RadioButton.TabStop = true;
            this.StreetFighter2RadioButton.Text = "Street Fighter II";
            this.StreetFighter2RadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StreetFighter2RadioButton.UseVisualStyleBackColor = true;
            this.StreetFighter2RadioButton.CheckedChanged += new System.EventHandler(this.StreetFighter2RadioButton_CheckedChanged);
            // 
            // MortalKombatRadioButton
            // 
            this.MortalKombatRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MortalKombatRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MortalKombatRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MortalKombatRadioButton.Location = new System.Drawing.Point(6, 19);
            this.MortalKombatRadioButton.Name = "MortalKombatRadioButton";
            this.MortalKombatRadioButton.Size = new System.Drawing.Size(104, 24);
            this.MortalKombatRadioButton.TabIndex = 0;
            this.MortalKombatRadioButton.TabStop = true;
            this.MortalKombatRadioButton.Text = "Mortal Kombat";
            this.MortalKombatRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MortalKombatRadioButton.UseVisualStyleBackColor = true;
            this.MortalKombatRadioButton.CheckedChanged += new System.EventHandler(this.MortalKombatRadioButton_CheckedChanged);
            // 
            // nextImageButton
            // 
            this.nextImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextImageButton.Font = new System.Drawing.Font("Lucida Console", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextImageButton.Location = new System.Drawing.Point(935, 483);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(37, 166);
            this.nextImageButton.TabIndex = 4;
            this.nextImageButton.Text = "→";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.NextImageButton_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameLabel.Location = new System.Drawing.Point(12, 9);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(960, 16);
            this.FileNameLabel.TabIndex = 5;
            this.FileNameLabel.Text = "FileName";
            // 
            // CharacterGroupBox
            // 
            this.CharacterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CharacterGroupBox.Controls.Add(this.PlayerTwoComboBox);
            this.CharacterGroupBox.Controls.Add(this.PlayerTwoLabel);
            this.CharacterGroupBox.Controls.Add(this.PlayerOneComboBox);
            this.CharacterGroupBox.Controls.Add(this.PlayerOneLabel);
            this.CharacterGroupBox.Location = new System.Drawing.Point(134, 483);
            this.CharacterGroupBox.Name = "CharacterGroupBox";
            this.CharacterGroupBox.Size = new System.Drawing.Size(163, 166);
            this.CharacterGroupBox.TabIndex = 6;
            this.CharacterGroupBox.TabStop = false;
            this.CharacterGroupBox.Text = "Characters";
            // 
            // fbd
            // 
            this.fbd.ShowNewFolderButton = false;
            // 
            // PlayerOneLabel
            // 
            this.PlayerOneLabel.AutoSize = true;
            this.PlayerOneLabel.Location = new System.Drawing.Point(6, 16);
            this.PlayerOneLabel.Name = "PlayerOneLabel";
            this.PlayerOneLabel.Size = new System.Drawing.Size(45, 13);
            this.PlayerOneLabel.TabIndex = 0;
            this.PlayerOneLabel.Text = "Player 1";
            // 
            // PlayerOneComboBox
            // 
            this.PlayerOneComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerOneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerOneComboBox.FormattingEnabled = true;
            this.PlayerOneComboBox.Location = new System.Drawing.Point(6, 32);
            this.PlayerOneComboBox.Name = "PlayerOneComboBox";
            this.PlayerOneComboBox.Size = new System.Drawing.Size(151, 21);
            this.PlayerOneComboBox.Sorted = true;
            this.PlayerOneComboBox.TabIndex = 1;
            // 
            // PlayerTwoComboBox
            // 
            this.PlayerTwoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerTwoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerTwoComboBox.FormattingEnabled = true;
            this.PlayerTwoComboBox.Location = new System.Drawing.Point(6, 72);
            this.PlayerTwoComboBox.Name = "PlayerTwoComboBox";
            this.PlayerTwoComboBox.Size = new System.Drawing.Size(151, 21);
            this.PlayerTwoComboBox.Sorted = true;
            this.PlayerTwoComboBox.TabIndex = 3;
            // 
            // PlayerTwoLabel
            // 
            this.PlayerTwoLabel.AutoSize = true;
            this.PlayerTwoLabel.Location = new System.Drawing.Point(6, 56);
            this.PlayerTwoLabel.Name = "PlayerTwoLabel";
            this.PlayerTwoLabel.Size = new System.Drawing.Size(45, 13);
            this.PlayerTwoLabel.TabIndex = 2;
            this.PlayerTwoLabel.Text = "Player 2";
            // 
            // ImageLabelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.CharacterGroupBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.nextImageButton);
            this.Controls.Add(this.GameGroupBox);
            this.Controls.Add(this.PictureBox);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "ImageLabelerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "ImageLabelerForm";
            this.Load += new System.EventHandler(this.ImageLabelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.GameGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox GameGroupBox;
        private System.Windows.Forms.RadioButton StreetFighter2RadioButton;
        private System.Windows.Forms.RadioButton MortalKombatRadioButton;
        private System.Windows.Forms.Button nextImageButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.GroupBox CharacterGroupBox;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.ComboBox PlayerTwoComboBox;
        private System.Windows.Forms.Label PlayerTwoLabel;
        private System.Windows.Forms.ComboBox PlayerOneComboBox;
        private System.Windows.Forms.Label PlayerOneLabel;
    }
}