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
            this.MortalKombatGroupBox = new System.Windows.Forms.GroupBox();
            this.CageCheckbox = new System.Windows.Forms.CheckBox();
            this.StreetFighter2GroupBox = new System.Windows.Forms.GroupBox();
            this.ChunLiCheckBox = new System.Windows.Forms.CheckBox();
            this.BlankaCheckbox = new System.Windows.Forms.CheckBox();
            this.nextImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.GameGroupBox.SuspendLayout();
            this.MortalKombatGroupBox.SuspendLayout();
            this.StreetFighter2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.Location = new System.Drawing.Point(12, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(960, 365);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // GameGroupBox
            // 
            this.GameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameGroupBox.Controls.Add(this.StreetFighter2RadioButton);
            this.GameGroupBox.Controls.Add(this.MortalKombatRadioButton);
            this.GameGroupBox.Location = new System.Drawing.Point(12, 383);
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
            this.StreetFighter2RadioButton.Location = new System.Drawing.Point(6, 49);
            this.StreetFighter2RadioButton.Name = "StreetFighter2RadioButton";
            this.StreetFighter2RadioButton.Size = new System.Drawing.Size(104, 24);
            this.StreetFighter2RadioButton.TabIndex = 1;
            this.StreetFighter2RadioButton.TabStop = true;
            this.StreetFighter2RadioButton.Text = "Street Fighter II";
            this.StreetFighter2RadioButton.UseVisualStyleBackColor = true;
            this.StreetFighter2RadioButton.CheckedChanged += new System.EventHandler(this.StreetFighter2RadioButton_CheckedChanged);
            // 
            // MortalKombatRadioButton
            // 
            this.MortalKombatRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MortalKombatRadioButton.Location = new System.Drawing.Point(6, 19);
            this.MortalKombatRadioButton.Name = "MortalKombatRadioButton";
            this.MortalKombatRadioButton.Size = new System.Drawing.Size(104, 24);
            this.MortalKombatRadioButton.TabIndex = 0;
            this.MortalKombatRadioButton.TabStop = true;
            this.MortalKombatRadioButton.Text = "Mortal Kombat";
            this.MortalKombatRadioButton.UseVisualStyleBackColor = false;
            this.MortalKombatRadioButton.CheckedChanged += new System.EventHandler(this.MortalKombatRadioButton_CheckedChanged);
            // 
            // MortalKombatGroupBox
            // 
            this.MortalKombatGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MortalKombatGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MortalKombatGroupBox.Controls.Add(this.CageCheckbox);
            this.MortalKombatGroupBox.Location = new System.Drawing.Point(134, 383);
            this.MortalKombatGroupBox.Name = "MortalKombatGroupBox";
            this.MortalKombatGroupBox.Size = new System.Drawing.Size(394, 166);
            this.MortalKombatGroupBox.TabIndex = 2;
            this.MortalKombatGroupBox.TabStop = false;
            this.MortalKombatGroupBox.Text = "Mortal Kombat";
            // 
            // CageCheckbox
            // 
            this.CageCheckbox.AutoSize = true;
            this.CageCheckbox.Location = new System.Drawing.Point(6, 19);
            this.CageCheckbox.Name = "CageCheckbox";
            this.CageCheckbox.Size = new System.Drawing.Size(51, 17);
            this.CageCheckbox.TabIndex = 0;
            this.CageCheckbox.Text = "Cage";
            this.CageCheckbox.UseVisualStyleBackColor = true;
            // 
            // StreetFighter2GroupBox
            // 
            this.StreetFighter2GroupBox.Controls.Add(this.ChunLiCheckBox);
            this.StreetFighter2GroupBox.Controls.Add(this.BlankaCheckbox);
            this.StreetFighter2GroupBox.Location = new System.Drawing.Point(534, 383);
            this.StreetFighter2GroupBox.Name = "StreetFighter2GroupBox";
            this.StreetFighter2GroupBox.Size = new System.Drawing.Size(395, 166);
            this.StreetFighter2GroupBox.TabIndex = 3;
            this.StreetFighter2GroupBox.TabStop = false;
            this.StreetFighter2GroupBox.Text = "Street Fighter II";
            // 
            // ChunLiCheckBox
            // 
            this.ChunLiCheckBox.AutoSize = true;
            this.ChunLiCheckBox.Location = new System.Drawing.Point(6, 42);
            this.ChunLiCheckBox.Name = "ChunLiCheckBox";
            this.ChunLiCheckBox.Size = new System.Drawing.Size(62, 17);
            this.ChunLiCheckBox.TabIndex = 1;
            this.ChunLiCheckBox.Text = "Chun Li";
            this.ChunLiCheckBox.UseVisualStyleBackColor = true;
            // 
            // BlankaCheckbox
            // 
            this.BlankaCheckbox.AutoSize = true;
            this.BlankaCheckbox.Location = new System.Drawing.Point(6, 19);
            this.BlankaCheckbox.Name = "BlankaCheckbox";
            this.BlankaCheckbox.Size = new System.Drawing.Size(59, 17);
            this.BlankaCheckbox.TabIndex = 0;
            this.BlankaCheckbox.Text = "Blanka";
            this.BlankaCheckbox.UseVisualStyleBackColor = true;
            // 
            // nextImageButton
            // 
            this.nextImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextImageButton.Font = new System.Drawing.Font("Lucida Console", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextImageButton.Location = new System.Drawing.Point(935, 383);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(37, 166);
            this.nextImageButton.TabIndex = 4;
            this.nextImageButton.Text = "→";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.NextImageButton_Click);
            // 
            // ImageLabelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.nextImageButton);
            this.Controls.Add(this.StreetFighter2GroupBox);
            this.Controls.Add(this.MortalKombatGroupBox);
            this.Controls.Add(this.GameGroupBox);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageLabelerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "ImageLabelerForm";
            this.Load += new System.EventHandler(this.ImageLabelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.GameGroupBox.ResumeLayout(false);
            this.MortalKombatGroupBox.ResumeLayout(false);
            this.MortalKombatGroupBox.PerformLayout();
            this.StreetFighter2GroupBox.ResumeLayout(false);
            this.StreetFighter2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.GroupBox GameGroupBox;
        private System.Windows.Forms.RadioButton StreetFighter2RadioButton;
        private System.Windows.Forms.RadioButton MortalKombatRadioButton;
        private System.Windows.Forms.GroupBox StreetFighter2GroupBox;
        private System.Windows.Forms.Button nextImageButton;
        private System.Windows.Forms.GroupBox MortalKombatGroupBox;
        private System.Windows.Forms.CheckBox BlankaCheckbox;
        private System.Windows.Forms.CheckBox CageCheckbox;
        private System.Windows.Forms.CheckBox ChunLiCheckBox;
    }
}