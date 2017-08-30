using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;

namespace SUSHI_HUNT
{
    public partial class frm_logoSplash : Form
    {
        Bitmap bmp_logo = new Bitmap("FEC_logo.png");
        sprite sprite_logo = new sprite("FEC_logo.png", new Point(51, 220), 331, 68);
        string musicPath;
        WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public frm_logoSplash()
        {
            InitializeComponent();
        }

        private void tim_logoTimer_Tick(object sender, EventArgs e)
        {
            frm_mainMenu openMenu = new frm_mainMenu(); //Instantiate new main menu form
            tim_logoTimer.Stop(); //Stop timer
            player.controls.stop(); //Stop music
            player.close(); //Close player [conserves RAM]
            Cursor.Show(); //Enable cursor visibility
            this.Close(); //Close logo form
        }

        private void frm_logoSplash_Load(object sender, EventArgs e)
        {
            Cursor.Hide(); //Disable cursor visibility
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); //Graphical settings
            Invalidate();
            musicPath = "logo.wav"; //set path to logo theme
            player.URL = musicPath; //set player's URL to path
            player.controls.play(); //play music
        }

        private void frm_logoSplash_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp_logo, 80, 150, 331, 68); //draw FEC logo to screen
        }

    }

}
