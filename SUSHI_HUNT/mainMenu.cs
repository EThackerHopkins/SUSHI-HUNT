using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SUSHI_HUNT
{
    public partial class frm_mainMenu : Form
    {
        string userName;
        string difficulty;
        float[] highScores = new float[0];
        string[] highScoreNames = new string[0];
        string musicPath;
        WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        ////////////////////////////////////////
        /////      HIGH SCORE METHODS      /////
        ////////////////////////////////////////

        public float[] getHighScores()
        {
            return highScores;
        }

        public string[] getHighScoreNames()
        {
            return highScoreNames;
        }

        public float getLastHighScore()
        {
            if (highScores.Length > 0) //if there is/are high score(s)
            {
                return highScores[0]; 
            }
            else
            {
                return 0.0F; //return 0 as default "high score"
            }
        }

        public void addLastHighScore(float newScore)
        {
            Array.Resize(ref highScores, highScores.Length + 1); //add new record to array
            highScores[highScores.Length - 1] = newScore; //add newScore to array
            Array.Resize(ref highScoreNames, highScoreNames.Length + 1);
            highScoreNames[highScoreNames.Length - 1] = userName; //add userName to array
            Array.Sort(highScores, highScoreNames); //sort scores and names arrays
        }

        public frm_mainMenu()
        {
            InitializeComponent();
        }

        private void btn_Instructions_Click(object sender, EventArgs e) //INSTRUCTION CLICK
        {
            player.controls.stop(); //stop music
            player.close(); //close player [conserves RAM]

            frm_Instructions openInstructions = new frm_Instructions(); //Create new instance of Instructions form
            this.Hide(); //Hide current form
            openInstructions.Show(this); //Display Instructions form and add reference to mainMenu form
        }

        private void btn_highScore_Click(object sender, EventArgs e) //HIGH SCORE CLICK
        {
            player.controls.stop(); //stop music
            player.close(); //close player [conserves RAM]

            frm_highScore openHighScore = new frm_highScore(); //Create new instance of High score form
            this.Hide(); //Hide current form
            openHighScore.Show(this); //Display High score form and add reference to mainMenu form
        }

        private void btn_EXIT_Click(object sender, EventArgs e) //EXIT BUTTON CLICK
        {
            switch(MessageBox.Show("Are you sure you wish to end the game?", "Exit game?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            
            //Instantiate new MessageBox that asks user if they wish to end the game
                //MessageBoxButtons.YesNo gives it "Yes" and "No" options
                //MessageBoxIcon.Warning sets the icon to the Windows Warning symbol within the MessageBox

            {
                case DialogResult.Yes:
                    //If user's choice is Yes
                    player.controls.stop(); //stop music
                    player.close(); //close player [conserves RAM]
                    System.Windows.Forms.Application.Exit();
                    //Exit the entire application
                    break;

                /* There is not a "No" option as that option would automatically return the player to the main menu, 
                 * rendering any such code redundant    */
            }

        }

        private void btn_playGame_Click(object sender, EventArgs e) //PLAY GAME CLICK
        {
            player.controls.stop(); //stop music
            player.close(); //close player [conserves RAM]

            frm_Maze openMaze = new frm_Maze(); //Create new instance of Maze form
            openMaze.accessDifficulty = difficulty;
            openMaze.Show(this); //open maze form and add reference to Main Menu form
            this.Hide(); //Hide current form
        }

        private void btn_confirmName_Click(object sender, EventArgs e) //CONFIRM NAME CLICK
        {
            if (txt_userName.Text != "") //if name is NOT blank (valid name has been entered)
            {
                userName = txt_userName.Text; //set name holder to entered name
                pnl_nameEntry.Hide(); //hide name entry panel
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Blank name entry"); //inform user of invalid name
            }
        }

        private void lbl_welcomeName_Load(object sender, PaintEventArgs e) //NAME LOAD
        {
            lbl_welcomeName.Text = "Welcome, " + userName + "!"; //greet player using entered name
        }

        private void combo_Difficulty_SelectedIndexChanged(object sender, EventArgs e) //CHANGE DIFFICULTY
        {
            difficulty = combo_Difficulty.SelectedItem.ToString(); //set combo box value to difficulty holder
        }

        private void btn_changeName_Click(object sender, EventArgs e) //CHANGE NAME CLICK
        {
            pnl_nameEntry.Show(); //show name entry panel
            txt_userName.Clear(); //clear name entry text box
        }

        private void musicTimer_Tick(object sender, EventArgs e) //INTRO 1 - INTRO 2 TIMER
        {
            musicTimer.Stop(); //stop music
            musicPath = "title2.wav"; //set path to title2
            player.URL = musicPath; //set player's URL to path
            player.settings.setMode("loop", true); //enable music to loop
        }

        private void frm_mainMenu_Load(object sender, EventArgs e) //ON LOAD
        {
            playMusic();
        }

        public void playMusic() //PLAY MUSIC FUNCTION
        {
            musicTimer.Start(); //start title1.wav timer
            musicPath = "title1.wav"; //set path to title1
            player.URL = musicPath; //set player's URL to path
            player.controls.play(); //play music
        }

        private void frm_mainMenu_Activated(object sender, EventArgs e) //ON MENU RETURN
        {
            playMusic();
        }
    }
}
