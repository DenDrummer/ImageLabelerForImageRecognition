using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            //(now part of the actual form)
            //FolderBrowserDialog fbd = new FolderBrowserDialog(); 

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

            // bring application to front
            WindowState = FormWindowState.Minimized;
            WindowState = FormWindowState.Normal;

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
                if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
                else if (dr == DialogResult.Yes)
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

            #region find game
            //find selected radio button. each radio button corresponds to a game
            RadioButton rb = GameGroupBox.Controls.OfType<RadioButton>().First(r => r.Checked);
            switch (rb.Name)
            {
                case "MortalKombatRadioButton":
                    //set game
                    newName.Append("MK");
                    break;
                case "StreetFighter2RadioButton":
                    //set game
                    newName.Append("SF2");
                    break;
                default:
                    MessageBox.Show($"UNRECOGNIZED RADIO BUTTON: {rb.Name}");
                    break;
            }
            #endregion
            #region tags
            /**if the selected text in the characters dropdownlists is not null or whitespace,
              * then add their ID as a tag
              */

            // add player one
            if (PlayerOneComboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(PlayerOneComboBox.SelectedItem.ToString()))
                newName.Append($"_{PlayerOneComboBox.SelectedItem.ToString()}");

            // add player two
            // TODO: only allow player 2 to be selected in the form when player 1 is not null or whitespace
            if (PlayerTwoComboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(PlayerTwoComboBox.SelectedItem.ToString()))
                newName.Append($"_{PlayerTwoComboBox.SelectedItem.ToString()}");
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
            ChangeGame("Mortal Kombat");
        }

        private void StreetFighter2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeGame("Street Fighter II");
        }

        private void ChangeGame(string game)
        {
            /*DisableTagsExcept(game);
            //re-enable the GroupBox related to the selected game
            gb.Enabled = true;*/
            
            ComboBox.ObjectCollection p1chars = PlayerOneComboBox.Items;
            ComboBox.ObjectCollection p2chars = PlayerTwoComboBox.Items;

            switch (game)
            {
                case "Mortal Kombat":
                    #region Player One
                    p1chars.Clear();
                    p1chars.AddRange(new[] { " ", "Cage", "Kano", "Liu Kang", "Raiden", "Scorpion", "Sonya", "Sub-Zero" });
                    #endregion
                    #region Player Two
                    p2chars.Clear();
                    p2chars.AddRange(new[] { " ", "Cage", "Goro", "Kano", "Liu Kang", "Raiden", "Scorpion", "Shang Tsung", "Sonya", "Sub-Zero" });
                    #endregion
                    break;
                case "Street Fighter II":
                    #region Player One
                    p1chars.Clear();
                    p1chars.AddRange(new[] { " ", "Blanka", "Chun Li", "Dhalsim", "E. Honda", "Guile", "Ken", "Ryu", "Zangief" });
                    #endregion
                    #region Player Two
                    p2chars.Clear();
                    p2chars.AddRange(new[] { " ", "Blanka", "Chun Li", "Dhalsim", "E. Honda", "Guile", "Ken", "Ryu", "Zangief" });
                    #endregion
                    break;
                default:
                    MessageBox.Show("You selected a game that has not been properly implemented yet. Please check if the devs are aware of this issue.");
                    break;
            }
        }
    }
}
