using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SUSHI_HUNT
{
    public partial class frm_Maze : Form
    {
        Bitmap bmp_maze = new Bitmap("maze.png");
        Bitmap pic_char = new Bitmap("character.png");
        Bitmap pic_sushi = new Bitmap("sushi.png");
        bool exitOpen, gameLost, gameWon, gamePaused = false;
        Color pixelColourBlack, pixelColourWhite, pixelColourGrey;
        Collision sushiCollision = new Collision();
        int char_x, char_y, MAX_Time, positionCount, sushiCollected, timeCount = 0;
        int sushiLimit;
        string musicPath;
        sprite sprite_char = new sprite("character.png", new Point(11, 11), 10, 10);
        WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();

        /* Due to the nature of instantiation with C Sharp, one has to set an image for sprite_char to use,
         * despite it being predetermined within the Load event.  */

        int[] easy_x = new int[]   {  46,  20,  20, 146, 228, 279, 304, 303, 131, 282, 514};
        int[] easy_y = new int[]   {  53, 115, 159, 194, 117, 112,  56, 208,  53, 245, 439};
        int[] medium_x = new int[] {  86,  20,  83, 148, 238, 173, 176, 274, 307, 245, 514};
        int[] medium_y = new int[] { 115, 214, 217,  29, 110, 145, 242, 306,  20, 150, 439};
        int[] hard_x = new int[]   {  44, 148, 110, 303, 185, 308, 223, 230, 145,  37, 514};
        int[] hard_y = new int[]   {  84,  51, 145,  48, 146, 280, 118, 243, 284, 212, 439};

        //Instantiate hard-coded x and y sushi positions for each difficulty

        sprite sprite_sushi = new sprite("sushi.png", new Point(46, 53), 10, 10);

        public string accessDifficulty { get; set; } //Retrieve difficulty string from main menu; see mainMenu.cs

        public frm_Maze()
        {
            InitializeComponent();
        }

        private void frm_Maze_Load(object sender, EventArgs e) //ON LOAD
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); //graphic settings
            Invalidate();

            switch (accessDifficulty) //Get difficulty from Main menu
            {
                default: //ON DEFAULT
                    bmp_maze = new Bitmap("maze.png"); //Set maze to easy
                    MAX_Time = 150; //Set time limit to 150 seconds
                    sprite_sushi = new sprite("sushi.png", new Point(46, 53), 10, 10);
                    pixelColourGrey = bmp_maze.GetPixel(164, 320); //Retrieve grey reference from pixel 164, 320 of maze
                    gameLost = false; //game is not lost
                    sushiLimit = 10; //sushi limit is 10
                    sprite_sushi.position.X = easy_x[0]; //set sushi positions
                    sprite_sushi.position.Y = easy_y[0];
                    break;

                case "Easy": //ON EASY
                    bmp_maze = new Bitmap("maze.png"); //Set maze to easy
                    MAX_Time = 150; //Set time limit to 150 (seconds)
                    sprite_sushi = new sprite("sushi.png", new Point(46, 53), 10, 10);
                    pixelColourGrey = bmp_maze.GetPixel(164, 320); //Retrieve grey reference from pixel 164, 320 of maze
                    sushiLimit = 10; //sushi limit is 10
                    break;

                case "Medium": //ON MEDIUM
                    bmp_maze = new Bitmap("maze2.png"); //Set maze to medium
                    MAX_Time = 120; //Set time limit to 120 (seconds)
                    sprite_sushi = new sprite("sushi.png", new Point(86, 115), 10, 10);
                    pixelColourGrey = bmp_maze.GetPixel(170, 320); //Retrieve grey reference from pixel 164, 320 of maze
                    sushiLimit = 10; //sushi limit is 10
                    break;

                case "Hard": //ON HARD
                    bmp_maze = new Bitmap("maze3.png"); //Set maze to hard
                    MAX_Time = 90; //Set time limit to 90 (seconds)
                    sprite_sushi = new sprite("sushi.png", new Point(44, 84), 10, 10);
                    pixelColourGrey = bmp_maze.GetPixel(169, 320); //Retrieve grey reference from pixel 164, 320 of maze
                    sushiLimit = 10; //sushi limit is 10
                    break;

                /* The maze images used are PNG, though are converted using C Sharp's Bitmap object.
                 * They are stored locally in the project's "bin" folder.   */
            }

            char_x = 15; //X position; value is 15 so that character does not collide with wall
            char_y = 15; //Y position; value is 15 for the same reason

            sprite_char.position.X = 15; //Set character's X position to avoid collision
            sprite_char.position.Y = 15; //Set character's Y position

            pixelColourWhite = bmp_maze.GetPixel(11, 11); //Retrieve colour white reference from pixel 11,11 of maze
            pixelColourBlack = bmp_maze.GetPixel(0, 0); //Retrieve black reference from pixel 0, 0 of maze
            Invalidate();

            musicPath = "maze.wav"; //set music path to maze.wav
            Player.URL = musicPath; //set player's URL to path
            Player.settings.setMode("loop", true); //enable maze.wav to loop
            Player.controls.play(); //play music
        }

        private void mazeTimer_Tick(object sender, EventArgs e) //MAZE TIMER TICK
        {
            timeCount++; //Increment counter
            lbl_TIMEDISPLAY.Text = timeCount.ToString(); //Write counters value to label

            if (timeCount == MAX_Time) //if time hits limit
            {
                Player.controls.stop(); //stop music
                Player.settings.setMode("loop", false); //disable music loop
                musicPath = "lose.wav"; //change path to lose.wav
                Player.URL = musicPath; //change player's URL to path
                Player.controls.play(); //play music
                mazeTimer.Stop(); //stop timer
                gameLost = true; //GAME IS LOST
                MessageBox.Show("Time's up! You didn't complete the maze in time...\n\nGo back to the main menu" +
                " and try again."); //inform user of loss    
            }
        }

        private void lbl_PAUSE_Click(object sender, EventArgs e) //PAUSE CLICK
        {
            if ((gameLost == false) || (gameWon == false)) //game can be paused while game is not yet won or lost
            {
                pauseGame();
            } 
        }

        private void lbl_RETURN_Click(object sender, EventArgs e) //RETURN TO MAIN MENU CLICK
        {
            Player.controls.stop(); //stop music
            Player.close(); //close player [conserves RAM]

            frm_mainMenu openMain = (frm_mainMenu)this.Owner; //Get Owner - main menu
            /* Reference to Owner is used instead of instantiating new main menu as the latter would result in
             * destruction of important player data! */

            this.Close(); //Close game form
            openMain.Show(); //Display main menu
        }

        private void frm_Maze_Paint(object sender, PaintEventArgs e) //PAINT GRAPHICS
        {
            e.Graphics.DrawImage(bmp_maze, 0, 0, 330, 330); //Draw maze image to form
            
            e.Graphics.DrawImage(pic_char, sprite_char.position.X, sprite_char.position.Y,
                sprite_char.width, sprite_char.height); //Draw character with dimensions; at specific maze position


            if ((sushiCollected == sushiLimit) && (exitOpen == false)) //if all sushi is collected
            {
                pauseGame();
                MessageBox.Show("You've collected all of the sushi! Now you can exit the maze!"); //inform user
                pauseGame();
                exitOpen = true; //open maze's exit
            }

        
        switch(accessDifficulty) //accessDifficulty gets difficulty option from Main Menu
        { 
            default: //ON DEFAULT
                if (sushiCollision.Collided_with_sprite(sprite_char, sprite_sushi) == true) //on collision
                {
                    positionCount++; //go to next position in position array
                    sprite_sushi.position.X = easy_x[positionCount]; //set new positions
                    sprite_sushi.position.Y = easy_y[positionCount];

                    e.Graphics.DrawImage(pic_sushi, sprite_sushi.position.X, sprite_sushi.position.Y, 
                        sprite_sushi.width, sprite_sushi.height); //draw sushi at new position

                    sushiCollected++; //increment sushi collected

                    lbl_SUSHI_DISPLAY.Text = sushiCollected.ToString(); //write sush collected to label
                }
                else if (sushiCollected != sushiLimit) //otherwise when Invalidating
                {
                    e.Graphics.DrawImage(pic_sushi, easy_x[positionCount], easy_y[positionCount], 
                        sprite_sushi.width, sprite_sushi.height); //draw sushi at same positon

                    sprite_sushi.position.X = easy_x[positionCount]; //set positions
                    sprite_sushi.position.Y = easy_y[positionCount];
                }
                break;

            case "Easy": //ON EASY
                if (sushiCollision.Collided_with_sprite(sprite_char, sprite_sushi) == true)
                {
                    positionCount++;
                    sprite_sushi.position.X = easy_x[positionCount];
                    sprite_sushi.position.Y = easy_y[positionCount];

                    e.Graphics.DrawImage(pic_sushi, sprite_sushi.position.X, sprite_sushi.position.Y,
                        sprite_sushi.width, sprite_sushi.height);

                    sushiCollected++;

                    lbl_SUSHI_DISPLAY.Text = sushiCollected.ToString();
                }
                else
                {
                    e.Graphics.DrawImage(pic_sushi, easy_x[positionCount], easy_y[positionCount], 
                        sprite_sushi.width, sprite_sushi.height);

                    sprite_sushi.position.X = easy_x[positionCount];
                    sprite_sushi.position.Y = easy_y[positionCount];
                }
                break;

            case "Medium": //ON MEDIUM
                if ((sushiCollision.Collided_with_sprite(sprite_char, sprite_sushi) == true) && 
                    (sushiCollected != sushiLimit))
                {
                    positionCount++;
                    sprite_sushi.position.X = medium_x[positionCount];
                    sprite_sushi.position.Y = medium_y[positionCount];

                    e.Graphics.DrawImage(pic_sushi, sprite_sushi.position.X, sprite_sushi.position.Y,
                        sprite_sushi.width, sprite_sushi.height);

                    sushiCollected++;

                    lbl_SUSHI_DISPLAY.Text = sushiCollected.ToString();

                }
                else
                {
                    e.Graphics.DrawImage(pic_sushi, medium_x[positionCount], medium_y[positionCount], 
                        sprite_sushi.width, sprite_sushi.height);

                    sprite_sushi.position.X = medium_x[positionCount];
                    sprite_sushi.position.Y = medium_y[positionCount];
                }
                break;

            case "Hard": //ON HARD
                if ((sushiCollision.Collided_with_sprite(sprite_char, sprite_sushi) == true) && 
                    (sushiCollected != sushiLimit))
                {
                    positionCount++;
                    sprite_sushi.position.X = hard_x[positionCount];
                    sprite_sushi.position.Y = hard_y[positionCount];

                    e.Graphics.DrawImage(pic_sushi, sprite_sushi.position.X, sprite_sushi.position.Y,
                        sprite_sushi.width, sprite_sushi.height);

                    sushiCollected++;

                    lbl_SUSHI_DISPLAY.Text = sushiCollected.ToString();

                }
                else
                {
                    e.Graphics.DrawImage(pic_sushi, hard_x[positionCount], hard_y[positionCount], 
                        sprite_sushi.width, sprite_sushi.height);

                    sprite_sushi.position.X = hard_x[positionCount];
                    sprite_sushi.position.Y = hard_y[positionCount];
                }
                break;       
        }

        }

        ////////////////////////////////
        ////        CONTROLS        ////
        ////////////////////////////////

        private void frm_Maze_KeyDown(object sender, KeyEventArgs e) //KEY DOWN
        {
            switch (e.KeyCode) //Take key press
            {
                case Keys.Up:
                    if ((bmp_maze.GetPixel((char_x), (char_y - 5)) == pixelColourWhite) &&
                       (bmp_maze.GetPixel((char_x + pic_char.Width), (char_y - 5)) == pixelColourWhite) &&
                       (gamePaused == false) && (gameLost == false) && (gameWon == false))

                        //if character is within 5 white pixels of maze wall
                    {
                        char_y = char_y - 5; //Move upwards
                            
                    }
                        break;

                case Keys.Right:
                    if ((bmp_maze.GetPixel((char_x + pic_char.Width + 5), (char_y)) == pixelColourWhite) &&
                        (bmp_maze.GetPixel((char_x + pic_char.Width + 5), (char_y + pic_char.Height)) == pixelColourWhite)
                        && (gamePaused == false) && (gameLost == false) && (gameWon == false))
                    {
                        char_x = char_x + 5; //Move right
                    }
                        break;

                case Keys.Down:
                    if ((bmp_maze.GetPixel((char_x), (char_y + pic_char.Height + 5)) == pixelColourWhite) &&
                        (bmp_maze.GetPixel((char_x + pic_char.Width), (char_y + pic_char.Height + 5)) == pixelColourWhite)
                        && (gamePaused == false) && (gameLost == false) && (gameWon == false))
                    {
                        char_y = char_y + 5; //Move downwards
                    }
                    else if ((bmp_maze.GetPixel((char_x), (char_y + pic_char.Height + 5)) == pixelColourGrey) &&
                        (bmp_maze.GetPixel((char_x + pic_char.Width), (char_y + pic_char.Height + 5)) == pixelColourGrey)
                        && (exitOpen == true) && (gamePaused == false) && (gameLost == false) && (gameWon == false))
                    {

                        //ALLOW USER TO PASS THROUGH EXIT WHEN IT IS OPEN

                        gameWon = true; //GAME IS WON
                        pauseGame();
                        frm_mainMenu temp_main = (frm_mainMenu)this.Owner; //REFERENCE MAIN MENU
                        
                        if ((timeCount < temp_main.getLastHighScore() || temp_main.getLastHighScore() == 0))
                        {
                            //if score is higher than current high score

                            Player.controls.stop(); //stop music
                            Player.settings.setMode("loop", false); //disabled music loop
                            musicPath = "win.wav"; //set music path to win.wav
                            Player.URL = musicPath; //set player's URL to path
                            Player.controls.play(); //play win music

                            MessageBox.Show(String.Format("Congratulations! You've won the game!" +
                                "\n\nNew high score! \n\n TIME: {0} seconds", timeCount));
                            //inform player of winning
                            
                            temp_main.addLastHighScore(timeCount); //add new high score
                        }
                        else //if score is not a high score
                        {
                            Player.controls.stop(); //stop music
                            Player.settings.setMode("loop", false); //disable music looping
                            musicPath = "win.wav"; //set music path to win.wav
                            Player.URL = musicPath; //set player's URL to path
                            Player.controls.play(); //play music

                            MessageBox.Show(String.Format("Congratulations! You've won the game!\n\nTIME: {0} seconds", 
                            timeCount));
                            //inform player of winning
                        }

                        MessageBox.Show(String.Format("Congratulations! You've won the game!\n\nTIME: {0} seconds",
                            timeCount));
                  

                    }
                        break;

                case Keys.Left:
                    if ((bmp_maze.GetPixel((char_x - 5), (char_y)) == pixelColourWhite) &&
                        (bmp_maze.GetPixel((char_x - 5), (char_y + pic_char.Height)) == pixelColourWhite) &&
                        (gamePaused == false) && ((gameLost == false) || (gameWon == false)))
                    {
                        char_x = char_x - 5; //Move left
                    }
                        break;

                case Keys.P:
                    pauseGame();
                    break;
            }

            sprite_char.position.X = char_x; //Re-adjust x position
            sprite_char.position.Y = char_y; //Re-adjust y position

            Invalidate();

            }

        public void pauseGame() //PAUSE GAME FUNCTION
        {
            if ((gamePaused == false) && ((gameLost == false) || (gameWon == false))) //if the game has not yet been paused
            {
                gamePaused = true; //Set pause flag to true
                mazeTimer.Stop(); //Stop timer
                Player.controls.pause(); //Pause music
                lbl_PAUSE.Text = "UNPAUSE"; //Set pause button text to "UNPAUSE"
            }
            else if ((gamePaused == true) && ((gameLost == false) || (gameWon == false))) //If the game has been paused
            {
                gamePaused = false; //Set pause flag to false
                mazeTimer.Start(); //Start timer
                Player.controls.play(); //Resume music
                lbl_PAUSE.Text = "PAUSE"; //Set pause button text to "PAUSE"
            }
        }

    }
}
