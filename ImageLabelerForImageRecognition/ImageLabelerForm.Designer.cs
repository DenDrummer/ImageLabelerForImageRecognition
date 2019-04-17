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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.mortalKombatRadioButton = new System.Windows.Forms.RadioButton();
            this.streetFighterIIRadioButton = new System.Windows.Forms.RadioButton();
            this.mortalKombatGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(960, 365);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameGroupBox.Controls.Add(this.streetFighterIIRadioButton);
            this.gameGroupBox.Controls.Add(this.mortalKombatRadioButton);
            this.gameGroupBox.Location = new System.Drawing.Point(12, 383);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(116, 166);
            this.gameGroupBox.TabIndex = 1;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Game";
            // 
            // mortalKombatRadioButton
            // 
            this.mortalKombatRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mortalKombatRadioButton.Location = new System.Drawing.Point(6, 42);
            this.mortalKombatRadioButton.Name = "mortalKombatRadioButton";
            this.mortalKombatRadioButton.Size = new System.Drawing.Size(104, 24);
            this.mortalKombatRadioButton.TabIndex = 0;
            this.mortalKombatRadioButton.TabStop = true;
            this.mortalKombatRadioButton.Text = "Mortal Kombat";
            this.mortalKombatRadioButton.UseVisualStyleBackColor = false;
            // 
            // streetFighterIIRadioButton
            // 
            this.streetFighterIIRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.streetFighterIIRadioButton.Location = new System.Drawing.Point(6, 92);
            this.streetFighterIIRadioButton.Name = "streetFighterIIRadioButton";
            this.streetFighterIIRadioButton.Size = new System.Drawing.Size(104, 24);
            this.streetFighterIIRadioButton.TabIndex = 1;
            this.streetFighterIIRadioButton.TabStop = true;
            this.streetFighterIIRadioButton.Text = "Street Fighter II";
            this.streetFighterIIRadioButton.UseVisualStyleBackColor = true;
            // 
            // mortalKombatGroupBox
            // 
            this.mortalKombatGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mortalKombatGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mortalKombatGroupBox.Location = new System.Drawing.Point(134, 383);
            this.mortalKombatGroupBox.Name = "mortalKombatGroupBox";
            this.mortalKombatGroupBox.Size = new System.Drawing.Size(394, 166);
            this.mortalKombatGroupBox.TabIndex = 2;
            this.mortalKombatGroupBox.TabStop = false;
            this.mortalKombatGroupBox.Text = "Mortal Kombat";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(534, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            this.nextImageButton.Click += new System.EventHandler(this.nextImageButton_Click);
            // 
            // ImageLabelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.nextImageButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mortalKombatGroupBox);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageLabelerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "ImageLabelerForm";
            this.Load += new System.EventHandler(this.ImageLabelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gameGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.RadioButton streetFighterIIRadioButton;
        private System.Windows.Forms.RadioButton mortalKombatRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextImageButton;
        private System.Windows.Forms.GroupBox mortalKombatGroupBox;
    }
}