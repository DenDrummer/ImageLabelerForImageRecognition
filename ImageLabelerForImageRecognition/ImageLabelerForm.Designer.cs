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
            this.nextImageButton = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.CharacterGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayerTwoComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerTwoLabel = new System.Windows.Forms.Label();
            this.PlayerOneComboBox = new System.Windows.Forms.ComboBox();
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.GameComboBox = new System.Windows.Forms.ComboBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.PlayerOneCheckBox = new System.Windows.Forms.CheckBox();
            this.PlayerTwoCheckBox = new System.Windows.Forms.CheckBox();
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
            this.PictureBox.Size = new System.Drawing.Size(960, 496);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // GameGroupBox
            // 
            this.GameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GameGroupBox.Controls.Add(this.PlayerTwoCheckBox);
            this.GameGroupBox.Controls.Add(this.PlayerOneCheckBox);
            this.GameGroupBox.Controls.Add(this.GameLabel);
            this.GameGroupBox.Controls.Add(this.GameComboBox);
            this.GameGroupBox.Location = new System.Drawing.Point(12, 530);
            this.GameGroupBox.Name = "GameGroupBox";
            this.GameGroupBox.Size = new System.Drawing.Size(132, 119);
            this.GameGroupBox.TabIndex = 1;
            this.GameGroupBox.TabStop = false;
            this.GameGroupBox.Text = "Game";
            // 
            // nextImageButton
            // 
            this.nextImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextImageButton.Font = new System.Drawing.Font("Lucida Console", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextImageButton.Location = new System.Drawing.Point(935, 530);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(37, 119);
            this.nextImageButton.TabIndex = 5;
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
            this.CharacterGroupBox.Location = new System.Drawing.Point(150, 530);
            this.CharacterGroupBox.Name = "CharacterGroupBox";
            this.CharacterGroupBox.Size = new System.Drawing.Size(163, 119);
            this.CharacterGroupBox.TabIndex = 6;
            this.CharacterGroupBox.TabStop = false;
            this.CharacterGroupBox.Text = "Characters";
            // 
            // PlayerTwoComboBox
            // 
            this.PlayerTwoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerTwoComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerTwoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerTwoComboBox.Enabled = false;
            this.PlayerTwoComboBox.FormattingEnabled = true;
            this.PlayerTwoComboBox.Location = new System.Drawing.Point(6, 72);
            this.PlayerTwoComboBox.Name = "PlayerTwoComboBox";
            this.PlayerTwoComboBox.Size = new System.Drawing.Size(151, 21);
            this.PlayerTwoComboBox.Sorted = true;
            this.PlayerTwoComboBox.TabIndex = 4;
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
            // PlayerOneComboBox
            // 
            this.PlayerOneComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerOneComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerOneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerOneComboBox.Enabled = false;
            this.PlayerOneComboBox.FormattingEnabled = true;
            this.PlayerOneComboBox.Location = new System.Drawing.Point(6, 32);
            this.PlayerOneComboBox.Name = "PlayerOneComboBox";
            this.PlayerOneComboBox.Size = new System.Drawing.Size(151, 21);
            this.PlayerOneComboBox.Sorted = true;
            this.PlayerOneComboBox.TabIndex = 3;
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
            // fbd
            // 
            this.fbd.ShowNewFolderButton = false;
            // 
            // GameComboBox
            // 
            this.GameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameComboBox.FormattingEnabled = true;
            this.GameComboBox.Location = new System.Drawing.Point(6, 32);
            this.GameComboBox.Name = "GameComboBox";
            this.GameComboBox.Size = new System.Drawing.Size(120, 21);
            this.GameComboBox.Sorted = true;
            this.GameComboBox.TabIndex = 1;
            this.GameComboBox.SelectedIndexChanged += new System.EventHandler(this.GameComboBox_SelectedIndexChanged);
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Location = new System.Drawing.Point(6, 16);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(35, 13);
            this.GameLabel.TabIndex = 3;
            this.GameLabel.Text = "Game";
            // 
            // PlayerOneCheckBox
            // 
            this.PlayerOneCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PlayerOneCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerOneCheckBox.Location = new System.Drawing.Point(6, 59);
            this.PlayerOneCheckBox.Name = "PlayerOneCheckBox";
            this.PlayerOneCheckBox.Size = new System.Drawing.Size(58, 24);
            this.PlayerOneCheckBox.TabIndex = 4;
            this.PlayerOneCheckBox.Text = "P1";
            this.PlayerOneCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerOneCheckBox.UseVisualStyleBackColor = true;
            this.PlayerOneCheckBox.CheckedChanged += new System.EventHandler(this.PlayerOneCheckBox_CheckedChanged);
            // 
            // PlayerTwoCheckBox
            // 
            this.PlayerTwoCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PlayerTwoCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerTwoCheckBox.Location = new System.Drawing.Point(70, 59);
            this.PlayerTwoCheckBox.Name = "PlayerTwoCheckBox";
            this.PlayerTwoCheckBox.Size = new System.Drawing.Size(56, 24);
            this.PlayerTwoCheckBox.TabIndex = 5;
            this.PlayerTwoCheckBox.Text = "P2";
            this.PlayerTwoCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerTwoCheckBox.UseVisualStyleBackColor = true;
            this.PlayerTwoCheckBox.CheckedChanged += new System.EventHandler(this.PlayerTwoCheckBox_CheckedChanged);
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
            this.GameGroupBox.PerformLayout();
            this.CharacterGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox GameGroupBox;
        private System.Windows.Forms.Button nextImageButton;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.GroupBox CharacterGroupBox;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.ComboBox PlayerTwoComboBox;
        private System.Windows.Forms.Label PlayerTwoLabel;
        private System.Windows.Forms.ComboBox PlayerOneComboBox;
        private System.Windows.Forms.Label PlayerOneLabel;
        private System.Windows.Forms.ComboBox GameComboBox;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.CheckBox PlayerTwoCheckBox;
        private System.Windows.Forms.CheckBox PlayerOneCheckBox;
    }
}