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
    public partial class frm_Instructions : Form
    {
        string musicPath;
        WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public frm_Instructions()
        {
            InitializeComponent();
        }

        private void txt_Instructions_Enter(object sender, EventArgs e)
        {
            txt_Instructions.Enabled = false;
            txt_Instructions.Enabled = true;
            //Prevent cursor from entering text box and highlighting all of the contained text (this looks ugly)
        }

        private void btn_returnMenu_Click(object sender, EventArgs e) //RETURN TO MAIN MENU CLICK
        {
            player.controls.stop(); //stop music
            player.close(); //close player [this conserves RAM]
            this.Owner.Show(); //show Owner form (Main Menu)
            this.Close(); //close Instructions form
        }

        private void frm_Instructions_Load(object sender, EventArgs e) //ON LOAD
        {
            musicPath = "help1.wav"; //set music path
            player.URL = musicPath; //set player's URL to path
            player.controls.play(); //play music
        }

        private void musicTimer_Tick(object sender, EventArgs e) //HELP1 - HELP2 TIMER
        {
            musicTimer.Stop(); //stop music
            musicPath = "help2.wav"; //set path to help2
            player.URL = musicPath; //set player's URL to path
            player.settings.setMode("loop", true); //enable help2 to loop
            player.controls.play(); //play music
        }

    }
}
