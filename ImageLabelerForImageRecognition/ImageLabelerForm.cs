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
            OpenFolder();
        }

        private void OpenFolder()
        {
            #region open folder
            //create a new folder browser dialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            bool validFolder = false;
            //keep asking for a new folder until a valid folder has been selected
            while (!validFolder)
            {
                //open the folder browser dialog
                DialogResult result = fbd.ShowDialog();
                //if a valid folder has been selected
                #region result handling
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //load all file names (including the full path)
                    files = Directory.GetFiles(fbd.SelectedPath);
                    //TODO: filter only images
                    //TODO: allow recursive search
                    //indicate a valid folder has been found so the loop can be exited
                    validFolder = true;
                } //if the folder browsing is canceled or aborted
                else if (result == DialogResult.Cancel || result == DialogResult.Abort)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you wish to exit the program?", "", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
                #endregion
            }
            #endregion

            //open the first file
            NextFile();
        }

        private void NextFile()
        {
            //if you're not on the last image
            if (currentFile < files.Length - 1)
            {
                //load image into the picturebox
                PictureBox.Image = Image.FromFile(files[++currentFile]);
                //load filename with full path to the label
                FileNameLabel.Text = files[currentFile]; //.Split('/').Last();
            }
            else
            {
                DialogResult dr = MessageBox.Show("No more images to label in this folder.\nWould you like to convert another folder?", "No more images", MessageBoxButtons.YesNo);
                if (dr==DialogResult.No)
                {
                    Application.Exit();
                }
                else if (dr==DialogResult.Yes)
                {
                    OpenFolder();
                }
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
            StringBuilder newName = new StringBuilder();

            #region find game and tags
            //find selected radio button. each radio button corresponds to a game
            RadioButton rb = GameGroupBox.Controls.OfType<RadioButton>().First(r => r.Checked);
            switch (rb.Name)
            {
                case "MortalKombatRadioButton":
                    //set game
                    newName.Append("MK");
                    #region MK tags
                    //append a tag for each character the user indicated to be visible on screen
                    if (CageCheckBox.Checked)
                        newName.Append("_Cage");
                    if (GoroCheckBox.Checked)
                        newName.Append("_Goro");
                    if (KanoCheckBox.Checked)
                        newName.Append("_Kano");
                    if (LiuKangCheckBox.Checked)
                        newName.Append("_Liu Kang");
                    if (RaidenCheckBox.Checked)
                        newName.Append("_Raiden");
                    if (ScorpionCheckBox.Checked)
                        newName.Append("_Scorpion");
                    if (ShangTsungCheckBox.Checked)
                        newName.Append("_Shang Tsung");
                    if (SonyaCheckBox.Checked)
                        newName.Append("_Sonya");
                    if (SubZeroCheckBox.Checked)
                        newName.Append("_Sub-Zero");
                    #endregion
                    break;
                case "StreetFighter2RadioButton":
                    //set game
                    newName.Append("SF2");
                    #region SF2 tags
                    //append a tag for each character the user indicated to be visible on screen
                    if (BlankaCheckBox.Checked)
                        newName.Append("_Blanka");
                    if (ChunLiCheckBox.Checked)
                        newName.Append("_Chun Li");
                    if (DhalsimCheckBox.Checked)
                        newName.Append("_Dhalsim");
                    if (EHondaCheckBox.Checked)
                        newName.Append("_E. Honda");
                    if (GuileCheckBox.Checked)
                        newName.Append("_Guile");
                    if (KenCheckBox.Checked)
                        newName.Append("_Ken");
                    if (RyuCheckBox.Checked)
                        newName.Append("_Ryu");
                    if (ZangiefCheckBox.Checked)
                        newName.Append("_Zangief");
                    #endregion
                    break;
                default:
                    MessageBox.Show($"UNRECOGNIZED RADIO BUTTON: {rb.Name}");
                    break;
            }
            #endregion

            // append a unique identifier and file extension
            newName.Append($"_{currentFile}.jpg");
            #endregion

            #region rename file
            //get the pathe to the folder where the image was found
            string path = files[currentFile].Substring(0, files[currentFile].LastIndexOf('\\'));
            //dispose original image so it's no longer used by the program and it can be renamed
            PictureBox.Image.Dispose();
            //rename file
            File.Move(files[currentFile], $"{path}\\{newName.ToString()}");
            #endregion
        }

        private void MortalKombatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeGame("Mortal Kombat", MortalKombatGroupBox);
        }

        private void DisableTagsExcept(string game)
        {
            #region Mortal Kombat
            //if game is not MK
            if (!game.Equals("Mortal Kombat"))
            {
                //disable the MK GroupBox
                MortalKombatGroupBox.Enabled = false;
                //and uncheck all checkboxes in the MK GroupBox
                foreach (CheckBox cb in MortalKombatGroupBox.Controls.OfType<CheckBox>())
                {
                    cb.Checked = false;
                }
            }
            #endregion
            #region Street Fighter II
            //if game is not SF2
            if (!game.Equals("Street Fighter II"))
            {
                //disable the SF2 GroupBox
                StreetFighter2GroupBox.Enabled = false;
                //and uncheck all checkboxes in the SF2 GroupBox
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
            //re-enable the GroupBox related to the selected game
            gb.Enabled = true;
        }
    }
}
