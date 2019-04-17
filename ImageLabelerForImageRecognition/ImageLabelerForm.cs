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
            if (currentFile < files.Length-1)
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
            //TODO: read game and tags and rename image accordingly
        }

        private void MortalKombatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisableTagsExcept("Mortal Kombat");
        }

        private void DisableTagsExcept(string game)
        {
            #region Mortal Kombat
            if (!game.Equals("Mortal Kombat"))
            {
                //TODO: disable Mortal Kombat tags
            }
            #endregion
            #region Street Fighter II
            if (!game.Equals("Street Fighter II"))
            {
                //TODO: disable Street Fighter II tags
            }
            #endregion
        }

        private void StreetFighter2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DisableTagsExcept("Street Fighter II");
        }
    }
}
