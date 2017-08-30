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
    public partial class frm_highScore : Form
    {
        string musicPath;
        WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public frm_highScore()
        {
            InitializeComponent();
        }

        private void btn_returnMenu_Click(object sender, EventArgs e) //RETURN TO MAIN MENU CLICK
        {
            player.controls.stop(); //stop music
            player.close(); //close player [conserves RAM]
            this.Owner.Show(); //show Owner form (Main Menu)
            this.Close(); //close form
        }

        private void frm_highScore_Load(object sender, EventArgs e) //ON LOAD
        {
            musicTimer.Start(); //start scores1 timer
            musicPath = "scores1.wav"; //set path to scores1
            player.URL = musicPath; //set player's URL to path
            player.controls.play(); //play music
            

            frm_mainMenu temp_main = (frm_mainMenu)this.Owner; //REERENCE MAIN MENU

            lbl_HIGH_SCORES.Text = String.Format("Current high score: {0} seconds", temp_main.getLastHighScore());
            //fetch highest score from game session

            float[] temp_highScores = temp_main.getHighScores();
            //fetch scores
            string[] temp_highScoreNames = temp_main.getHighScoreNames();
            //fetch names

            for (int count = 0; count < temp_highScores.Length; count++) //for the amount of data in score arrays
            {
                list_highScores.Items.Add(String.Format("Name: {1, -10} : {0} seconds", 
                    temp_highScores[count], temp_highScoreNames[count])); //display scores in list
            }
        }

        private void musicTimer_Tick(object sender, EventArgs e) //SCORES 1 - SCORES 2 TIMER
        {
            musicTimer.Stop(); //stop music
            musicPath = "scores2.wav"; //set path to score2
            player.URL = musicPath; //set URL to path
            player.settings.setMode("loop", true); //enable score2 to loop
            player.controls.play(); //play music
        }
    }
}
