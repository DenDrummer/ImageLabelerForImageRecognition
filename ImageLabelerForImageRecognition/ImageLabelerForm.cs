using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ImageLabelerForImageRecognition
{
    public partial class ImageLabelerForm : Form
    {
        private string[] files;
        private int currentFile = -1;
        private Game game;
        //private int players = 0;

        public ImageLabelerForm()
        {
            InitializeComponent();
        }

        private void ImageLabelerForm_Load(object sender, EventArgs e)
        {
            OpenFolder();
            GameComboBox.Items.Clear();
            string[] games = Enum.GetNames(typeof(Game));
            for (int i = 0; i < games.Length; i++)
            {
                games[i] = GameToString(games[i]);
            }
            GameComboBox.Items.AddRange(games);
        }

        private void OpenFolder()
        {
            #region open folder
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
                    if (dr == DialogResult.OK || dr == DialogResult.Yes)
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
            #region unless last image
            //if you're not on the last image
            if (currentFile < files.Length - 1)
            {
                //load image into the picturebox
                PictureBox.Image = Image.FromFile(files[++currentFile]);
                //load filename with full path to the label
                FileNameLabel.Text = files[currentFile];
                //to only use the file name without the full path, add the code below to the line above
                //.Split('/').Last();
            }
            #endregion
            #region at last image
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
            #endregion
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
            //set game
            newName.Append(GameToString(game.ToString()));
            #endregion
            #region tags
            /**if the selected text in the characters dropdownlists is not null or whitespace,
              * then add their ID as a tag
              */

            #region players
            // add players in integer form
            int players = 0;
            if (PlayerOneCheckBox.Checked)
            {
                players += 1;
            }
            if (PlayerTwoCheckBox.Checked)
            {
                players += 2;
            }
            newName.Append($"_{players}");
            #endregion

            #region player characters
            // add player one
            newName.Append("_");
            if (PlayerOneComboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(PlayerOneComboBox.SelectedItem.ToString()))
                newName.Append($"{PlayerOneComboBox.SelectedItem.ToString()}");

            // add player two
            newName.Append("_");
            if (PlayerTwoComboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(PlayerTwoComboBox.SelectedItem.ToString()))
                newName.Append($"{PlayerTwoComboBox.SelectedItem.ToString()}");
            #endregion
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

        private string GameToString(string game)
            => game.Replace('_', ' ').Trim();

        private string StringToGame(string game)
        {
            string regex = "^\\d";
            if (Regex.IsMatch(game, regex))
            {
                game = $"_{game}";
            }
            return game.Replace(' ', '_');
        }

        private void UpdateGame(Game game)
        {
            ComboBox.ObjectCollection p1charlist = PlayerOneComboBox.Items;
            ComboBox.ObjectCollection p2charlist = PlayerTwoComboBox.Items;

            //reset game label color
            GameLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);

            #region fill char lists
            List<string> chars = new List<string>() { " " };
            List<string> p1chars = new List<string>();
            List<string> p2chars = new List<string>();

            switch (game)
            {
                case Game._1943:
                    break;
                case Game.Asterix:
                    #region Asterix chars
                    chars.AddRange(new string[] {
                        "Asterix",
                        "Obelix" });
                    #endregion
                    break;
                case Game.Frogger:
                    break;
                case Game.Gyruss:
                    break;
                case Game.Mortal_Kombat:
                    #region mk chars
                    chars.AddRange(new string[] {
                        "Cage",
                        "Kano",
                        "Liu Kang",
                        "Raiden",
                        "Scorpion",
                        "Sonya",
                        "Sub-Zero" });

                    p2chars.AddRange(new string[] {
                        "Goro",
                        "Shang Tsung" });
                    #endregion
                    break;
                case Game.Pang:
                    break;
                case Game.Super_Street_Fighter_II_Turbo:
                    #region ssf2t chars
                    chars.AddRange(new string[] {
                        "Balrog",
                        "Blanka",
                        "Cammy",
                        "Dee Jay",
                        "Chun Li",
                        "Dhalsim",
                        "E. Honda",
                        "Fei Long",
                        "Guile",
                        "Ken",
                        "M. Bison",
                        "Ryu",
                        "Sagat",
                        "T. Hawk",
                        "Vega",
                        "Zangief" });
                    #endregion
                    break;
                default:
                    GameLabel.ForeColor = Color.Red;
                    //MessageBox.Show("You selected a game that has not been properly implemented yet. Please check if the devs are aware of this issue.");
                    break;
            }
            #endregion
            #region actually update the combobox lists
            p1charlist.Clear();
            p1charlist.AddRange(chars.ToArray());
            p1charlist.AddRange(p1chars.ToArray());

            p2charlist.Clear();
            p2charlist.AddRange(chars.ToArray());
            p1charlist.AddRange(p2chars.ToArray());

            UpdatePlayers();
            #endregion
        }

        private void GameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameComboBox.SelectedItem != null && !string.IsNullOrWhiteSpace(GameComboBox.SelectedItem.ToString()))
            {
                PlayerOneCheckBox.Enabled = true;
                PlayerTwoCheckBox.Enabled = true;
                foreach (Game game in Enum.GetValues(typeof(Game)))
                {
                    if (StringToGame(GameComboBox.SelectedItem.ToString()).Equals(game.ToString()))
                    {
                        this.game = game;
                        UpdateGame(game);
                    }
                }
            }
            else
            {
                PlayerOneCheckBox.Enabled = false;
                PlayerTwoCheckBox.Enabled = false;
            }
        }

        private void UpdatePlayers()
        {
            #region determine playercount
            //set playercount to 0
            int players = 0;

            //if the current game is a game with player-selection
            if (game.Equals(Game.Asterix) ||
                game.Equals(Game.Mortal_Kombat) ||
                game.Equals(Game.Super_Street_Fighter_II_Turbo))
            {
                players = 3;
            }
            #endregion
            #region en-/disable comboboxes
            switch (players)
            {
                case 0:
                    PlayerOneComboBox.Enabled = false;
                    PlayerTwoComboBox.Enabled = false;
                    break;
                case 1:
                    PlayerOneComboBox.Enabled = true;
                    PlayerTwoComboBox.Enabled = false;
                    break;
                case 2:
                    PlayerOneComboBox.Enabled = false;
                    PlayerTwoComboBox.Enabled = true;
                    break;
                case 3:
                    PlayerOneComboBox.Enabled = true;
                    PlayerTwoComboBox.Enabled = true;
                    break;
                default:
                    break;
            }
            #endregion
        }
    }
}
