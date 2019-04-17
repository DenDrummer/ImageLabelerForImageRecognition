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
            pictureBox.Image = Image.FromFile(files[++currentFile]);
        }

        private void nextImageButton_Click(object sender, EventArgs e)
        {
            RenameImage();
            NextFile();
        }

        private void RenameImage()
        {
            //TODO: read game and tags and rename image accordingly
        }
    }
}
