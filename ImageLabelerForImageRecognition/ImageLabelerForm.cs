using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLabelerForImageRecognition
{
    public partial class ImageLabelerForm : Form
    {
        private string[] files;
        private int currentFile = -1;

        public ImageLabelerForm()
        {
            InitializeComponent();
        }

        private void ImageLabelerForm_Load(object sender, EventArgs e)
        {
            #region open folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //extra: filter so only folders and jpg images are shown.
            bool validFolder = false;
            while (!validFolder)
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);
                    //TODO: filter only images
                    validFolder = true;
                }
            }
            #endregion

            #region [old] print file paths
            // this code was to see how the files are loaded in
            //StringBuilder fileList = new StringBuilder();
            //for (int i = 0; i < files.Length; i++)
            //{
            //    fileList.Append(files[i]);
            //    if (i != files.Length - 1)
            //    {
            //        fileList.Append("\n");
            //    }
            //}
            //MessageBox.Show(fileList.ToString());
            #endregion

            NextFile();
        }

        private void NextFile()
        {
            if (currentFile < files.Length - 1)
            {
                PictureBox.Image = Image.FromFile(files[++currentFile]);
            }
            else
            {
                MessageBox.Show("No more images to label");
                //TODO: allow to convert other folders
                Application.Exit();
            }
        }

        private void NextImageButton_Click(object sender, EventArgs e)
        {
            RenameImage();
            NextFile();
        }

        private void RenameImage()
        {
            #region build name
            //TODO: read game and tags and rename image accordingly
            StringBuilder newName = new StringBuilder();
            #region find game
            RadioButton rb = GameGroupBox.Controls.OfType<RadioButton>().First(r => r.Checked);
            switch (rb.Name)
            {
                case "MortalKombatRadioButton":
                    newName.Append("MK");
                    break;
                case "StreetFighter2RadioButton":
                    newName.Append("SF2");
                    break;
                default:
                    MessageBox.Show($"UNRECOGNIZED RADIO BUTTON: {rb.Name}");
                    break;
            }
            #endregion
            #region read player tags
            //TODO: read player tags
            #endregion

            // append a unique identifier
            newName.Append($"_{currentFile}");
            #endregion

            #region save new file
            //TODO: save new file
            #endregion

            #region delete old file
            //TODO: delete old file
            #endregion
        }

        private void MortalKombatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeGame("Mortal Kombat", MortalKombatGroupBox);
        }

        private void DisableTagsExcept(string game)
        {
            #region Mortal Kombat
            if (!game.Equals("Mortal Kombat"))
            {
                MortalKombatGroupBox.Enabled = false;
                foreach (CheckBox cb in MortalKombatGroupBox.Controls.OfType<CheckBox>())
                {
                    cb.Checked = false;
                }
            }
            #endregion
            #region Street Fighter II
            if (!game.Equals("Street Fighter II"))
            {
                StreetFighter2GroupBox.Enabled = false;
                foreach (CheckBox cb in StreetFighter2GroupBox.Controls.OfType<CheckBox>())
                {
                    cb.Checked = false;
                }
            }
            #endregion
        }

        private void StreetFighter2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeGame("Street Fighter II", StreetFighter2GroupBox);
        }

        private void ChangeGame(string game, GroupBox gb)
        {
            DisableTagsExcept(game);
            gb.Enabled = true;
        }
    }
}
