using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ImageLabelerForImageRecognition
{
    public partial class ImageLabelerForm : Form
    {
        private string[] files;
        private int currentFileId = -1;
        private Game game;
        private string idStorePath;

        public ImageLabelerForm()
        {
            InitializeComponent();
        }

        private void ImageLabelerForm_Load(object sender, EventArgs e)
        {
            OpenFolder();
            
            if (File.Exists(idStorePath))
            {
                currentFileId = int.Parse(File.ReadAllText(idStorePath));
            }
            else
            {
                File.CreateText(idStorePath).Close();
            }

            GameComboBox.Items.Clear();
            string[] games = Enum.GetNames(typeof(Game));
            for (int i = 0; i < games.Length; i++)
            {
                games[i] = GameToString(games[i]);
            }
            GameComboBox.Items.AddRange(games);
            GameComboBox.SelectedIndex = 0;
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
                    /** load all file names (including the full path)
                      * fbd.SelectedPath            :   the "root" folder
                      * "*.jpg"                     :   only load .jpg images
                      * SearchOption.AllDirectories :   also look in subdirectories
                      */
                    files = Directory.GetFiles(fbd.SelectedPath, "*.jpg", SearchOption.AllDirectories);

                    idStorePath = $"{fbd.SelectedPath}\\_last_id.txt";
                    
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
            if (currentFileId < files.Length - 1)
            {
                bool unconvertedImage = false;
                while (!unconvertedImage)
                {
                    string convertedFileName = "[a-zA-Z 0-9]*_[0-3](_[a-zA-Z. -]{2}_[0-9]+.jpg";

                    //if the file has not been converted yet
                    if (!Regex.IsMatch(files[currentFileId].Split('/').Last(), convertedFileName))
                    {
                        #region unconverted image
                        //load image into the picturebox
                        PictureBox.Image = Image.FromFile(files[++currentFileId]);
                        //load filename with full path to the label
                        FileNameLabel.Text = files[currentFileId];
                        //to only use the file name without the full path, add the code below to the line above
                        //.Split('/').Last();

                        //exit while loop
                        unconvertedImage = true;
                        #endregion
                    }
                    else
                    {
                        //if already converted move to the next file
                        currentFileId++;
                    }
                }
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
            // get current game
            string currGame = GameToString(game.ToString());
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
            newName.Append($"_{currentFileId}.jpg");
            #endregion
            
            #region rename file
            //get the pathe to the folder where the image was found
            string path = files[currentFileId].Substring(0, files[currentFileId].LastIndexOf('\\'));
            //dispose original image so it's no longer used by the program and it can be renamed
            PictureBox.Image.Dispose();
            //rename file
            File.Move(files[currentFileId], $"{path}\\{newName.ToString()}");
            #endregion

            #region update id in txt file
            if (!File.Exists(idStorePath))
            {
                File.Create(idStorePath).Close();
            }
            File.WriteAllText(idStorePath, currentFileId.ToString());
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
            else if (string.IsNullOrWhiteSpace(game))
            {
                game = "_";
            }
            return game.Replace(' ', '_');
        }

        private void UpdateGame(Game game)
        {
            ComboBox.ObjectCollection p1charlist = PlayerOneComboBox.Items;
            ComboBox.ObjectCollection p2charlist = PlayerTwoComboBox.Items;

            //reset next-image-button
            nextImageButton.Enabled = true;
            //reset game label color
            GameLabel.ForeColor = Color.FromKnownColor(KnownColor.ControlText);

            #region fill char lists
            List<string> chars = new List<string>() { " " };
            List<string> p1chars = new List<string>();
            List<string> p2chars = new List<string>();

            switch (game)
            {
                case Game._:
                case Game._1943:
                case Game.Astyanax:
                case Game.Donkey_Kong:
                case Game.Double_Dragon:
                case Game.Frogger:
                case Game.Galaga_88:
                case Game.Galaxian:
                case Game.Gyruss:
                case Game.Metal_Slug:
                case Game.Pang:
                case Game.Tetris:
                case Game.Space_Invaders_Part_II:
                    break;
                case Game.Asterix:
                    #region Asterix chars
                    chars.AddRange(new string[]
                    {
                        "Asterix",
                        "Obelix"
                    });
                    #endregion
                    break;
                case Game.Contra:
                    #region Contra chars
                    p1chars.Add("Bill");
                    p2chars.Add("Lance");
                    #endregion
                    break;
                case Game.Golden_Axe_The_Revenge_Of_Death_Adder:
                    #region GATRODA chars
                    chars.AddRange(new string[]
                    {
                        "Dora",
                        "Goah",
                        "Sternblade",
                        "Trix"
                    });
                    #endregion
                    break;
                case Game.Mario_Bros:
                    #region MaBro chars
                    p1chars.Add("Mario");
                    p2chars.Add("Luigi");
                    #endregion
                    break;
                case Game.Marvel_Super_Heroes_vs_Street_Fighter:
                    #region MaSHeVStreF chars
                    chars.AddRange(new string[]
                    {
                        "Akuma",
                        "Bison",
                        "Blackheart",
                        "Captain America",
                        "Chun-Li",
                        "Cyclops",
                        "Dan",
                        "Dhalsim",
                        "Hulk",
                        "Ken",
                        "Omega Red",
                        "Ryu",
                        "Sakura",
                        "Shuma-Gurath",
                        "Spiderman",
                        "Zangief"
                    });
                    #endregion
                    break;
                case Game.Mortal_Kombat:
                    #region MoKo chars
                    #region playable
                    chars.AddRange(new string[]
                    {
                        "Cage",
                        "Kano",
                        "Liu Kang",
                        "Raiden",
                        "Scorpion",
                        "Sonya",
                        "Sub-Zero"
                    });
                    #endregion
                    #region bosses
                    p2chars.AddRange(new string[]
                    {
                        "Goro",
                        "Shang Tsung"
                    });
                    #endregion
                    #endregion
                    break;
                case Game.Sega_Sonic_The_Hedgehog:
                    #region SeSTHe chars
                    chars.AddRange(new string[]
                    {
                        "Mighty",
                        "Ray",
                        "Sonic"
                    });
                    #endregion
                    break;
                case Game.Sonic_The_Hedgehog_II:
                    #region SoTH2 chars
                    p1chars.Add("Sonic");
                    p2chars.Add("Tails");
                    #endregion
                    break;
                case Game.Street_Fighter_II_Champion_Edition:
                    #region StreF2ChE chars
                    chars.AddRange(new string[]
                    {
                        "Balrog",
                        "Blanka",
                        "Chun Li",
                        "Dhalsim",
                        "E. Honda",
                        "Guile",
                        "Ken",
                        "M. Bison",
                        "Ryu",
                        "Sagat",
                        "Vega",
                        "Zangief"
                    });
                    #endregion
                    break;
                case Game.Street_Fighter_III_New_Generation:
                    #region StreF3NeG chars
                    chars.AddRange(new string[]
                    {
                        "Alex",
                        "Dudley",
                        "Elena",
                        "Ibuki",
                        "Ken",
                        "Necro",
                        "Oro",
                        "Ryu",
                        "Sean",
                        "Yun"
                    });
                    #endregion
                    break;
                case Game.Super_Street_Fighter_II_The_New_Challenger:
                case Game.Super_Street_Fighter_II_Turbo:
                    #region SuStreF2 chars
                    chars.AddRange(new string[]
                    {
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
                        "Zangief"
                    });
                    #endregion
                    break;
                case Game.The_King_Of_Fighters_96:
                    #region TheKOF96 chars
                    #region playable
                    chars.AddRange(new string[]
                    {
                        "Andy Bogard",
                        "Athena Asamiya",
                        "Benimaru Nikaido",
                        "Chang Koehan",
                        "Chin Gentsai",
                        "Choi Bounge",
                        "Clark Still",
                        "Geese Howard",
                        "Goro Daimon",
                        "Iori Yagami",
                        "Joe Higashi",
                        "Kasumi Todoh",
                        "Kim Kaphwan",
                        "King",
                        "Kyo Kusanagi",
                        "Leona Heidern",
                        "Mai Shiranui",
                        "Mature",
                        "Mr. Big",
                        "Ralf Jones",
                        "Robert Garcia",
                        "Ryo Sakazaki",
                        "Sie Kensou",
                        "Terry Bogard",
                        "Vice",
                        "Wolfgang Krauser",
                        "Yuri Sakazaki"
                    });
                    #endregion
                    #region bosses
                    p2chars.AddRange(new string[]
                    {
                        "Chizuru Kagura",
                        "Goenitz"
                    });
                    #endregion
                    #endregion
                    break;
                case Game.The_Punisher:
                    #region TheP chars
                    p1chars.Add("The Punisher");
                    p2chars.Add("Nick Fury");
                    #endregion
                    break;
                default:
                    //indicate the game hasn't been propperly implemented yet and prevent from labeling
                    GameLabel.ForeColor = Color.Red;
                    nextImageButton.Enabled = false;
                    break;
            }

            //remove the empty ones from the p1 and p2 exclusive lists
            #endregion
            #region actually update the combobox lists
            p1charlist.Clear();
            p1charlist.AddRange(chars.ToArray());
            p1charlist.AddRange(p1chars.ToArray());

            p2charlist.Clear();
            p2charlist.AddRange(chars.ToArray());
            p2charlist.AddRange(p2chars.ToArray());

            UpdatePlayers();
            #endregion
        }

        private void GameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GameComboBox.SelectedItem != null)
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
            #region old code
            /*
            #region determine playercount
            //set playercount to 0
            int players = 0;

            //if the current game is a game with player-selection
            if (game.Equals(Game.Asterix) ||
                game.Equals(Game.Astyanax) ||
                game.Equals(Game.Mortal_Kombat) ||
                game.Equals(Game.Street_Fighter_II_Champion_Edition) ||
                game.Equals(Game.Street_Fighter_III_New_Generation) ||
                game.Equals(Game.Super_Street_Fighter_II_The_New_Challenger) ||
                game.Equals(Game.Super_Street_Fighter_II_Turbo))
            {
                players = 3;
            }
            else if (game.Equals(Game.Sonic_The_Hedgehog_II))
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
            */
            #endregion
            #region p1 charlist
            if (PlayerOneComboBox.Items.Count > 1)
            {
                PlayerOneComboBox.Enabled = true;
            }
            else
            {
                PlayerOneComboBox.Enabled = false;
            }
            #endregion
            #region p1 charlist
            if (PlayerTwoComboBox.Items.Count > 1)
            {
                PlayerTwoComboBox.Enabled = true;
            }
            else
            {
                PlayerTwoComboBox.Enabled = false;
            }
            #endregion
            #region select defaults
            PlayerOneComboBox.SelectedIndex = 0;
            PlayerTwoComboBox.SelectedIndex = 0;
            #endregion
        }
    }
}
