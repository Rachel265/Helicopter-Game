using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helicopter_Game
{
    public partial class Form1 : Form
    {
        // enter the variables
        bool goup; // this is a boolean to allow player to go up
        bool godown; // this is a boolean to allow player to go down
        bool shot = false; // this will check if the player has shot any bullets
        int score = 0; // this is a integer for player to keep score
        int speed = 8; // this is the speed of obstacles and ufos
        Random rand = new Random(); // this is the random class to generate a random number
        int playerSpeed = 7; // this interger will control how fast the player moves
        int index; // this is a empty integer which will be used to change the UFO images



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if the player has pressed down the up key
                // we change the go up to true
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                // if the player has pressed down the down key
                // we change the go down to true
                godown = true;
            }

            if (e.KeyCode == Keys.Space && shot == false)
            {
                // if the player has pressed down space key
                // AND shot boolean is false when they did
                // then we run the make bullet function
                // and change the shot from false to true
                makeBullet();
                shot = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // if the player has left the up key
                // change go up to false
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                // if the player has left the down key
                // change go down to false
                godown = false;
            }

            if (shot == true)
            {
                //if shot variable is true 
                // we change it false so the player will have to shoot again
                // for more bullet. 
                shot = false;
            }
        }
        private void gametick(object sender, EventArgs e)
        {
            {
                // move pillar 1 towards the left of the screen
                pillar1.Left -= speed;

                // move pillar 2 towards the left of the screen
                pillar2.Left -= speed;

                // move ufo towards the left of the screen
                ufo.Left -= speed;

                // show the score on label 1
                txtScore.Text = "Score: " + score;


                if (goup)
                {
                    // if go up is true then move the player up the screen
                    // notice its minus equals means it will deduct from the top location
                    // thus moving the player upwards
                    player.Top -= playerSpeed;
                }

                if (godown)
                {
                    // if go down is true then move the player down the screen
                    // notice its plus equals means it will add to the top location
                    // thus moving the player downwards
                    player.Top += playerSpeed;
                }


                if (pillar1.Left < -150)
                {
                    // if pillar 1 has gone past -150 which is off the screen
                    // then move it to 900 pixels to the right of the screen
                    // it will appear to have a continuous motion from right to left
                    pillar1.Left = 900;
                }

                if (pillar2.Left < -150)
                {
                    // if pillar 2 has gone past -150 which is off the screen
                    // then move it to 1000 pixels to the right of the screen
                    // it will appear to have a continuous motion from right to left
                    pillar2.Left = 1000;
                }


                // the two || symbols represent the OR option in If statements
                // the below if statement is logically checking the following
                // if UFO has left the screen towards the left
                // OR
                // player has collided with the UFO object on screen
                // OR
                // player has collided with pillar 1 object
                // OR 
                // player has collided with pillar 2 object
                // then follow the instructions inside the statement
                // we are able to check multiple conditions at the if statement

                if (ufo.Left < -5 ||
                    player.Bounds.IntersectsWith(ufo.Bounds) ||
                    player.Bounds.IntersectsWith(pillar1.Bounds) ||
                    player.Bounds.IntersectsWith(pillar2.Bounds)
                    )
                {
                    // if one of the above is true then we stop the timer
                    gameTimer.Stop();
                    // the game will show the final score to the player in a message box
                    MessageBox.Show("You failed the mission, you Killed " + score + " Ufo's");
                }

                // below is a for loop thats checking the components in this form
                // first we created a valiable called X in this form
                // x will be linked to the bullet object 
                // it will find out if the bullet object exist

                foreach (Control X in this.Controls)
                {

                    // if X is a picture box object AND it has a tag of bullet
                    // then we will follow the instructions within

                    if (X is PictureBox && X.Tag == "bullet")
                    {
                        // move x towards the right of the screen
                        X.Left += 15;

                        // if x has left the screen towards the right
                        // x's location is greater than 900 pixels from the screen
                        if (X.Left > 900)
                        {
                            // then remove x from display
                            this.Controls.Remove(X);

                            // dispose the x from the application
                            // we use the dispose method so it doesn't leak memory later on
                            X.Dispose();
                        }

                        // below we will check if X collides with the UFO object
                        if (X.Bounds.IntersectsWith(ufo.Bounds))
                        {
                            // is X collides with the UFO object

                            // add 1 to the score
                            score += 1;

                            // remove the bullet from the screen
                            this.Controls.Remove(X);

                            // dispose the bullet from the program
                            X.Dispose();

                            // move the UFO object 1000 pixels off the screen
                            ufo.Left = 1000;

                            // generate a random vertical location for the UFO
                            ufo.Top = rand.Next(5, 330) - ufo.Height;

                            // run the change UFO function it appears like a different UFO
                            changeUFO();
                        }
                    }
                }
            }
        }

  

        private void changeUFO()
        {
            index += 1; // increase index by 1

            if (index > 3)
            {
                // if indexes value is greater than 3
                // set it back to 1
                index = 1;
            }

            // we will use the switch statement to switch between alien images
            // by using the number in index we can switch them effectively
            // when the numbers in index change this switch statement will follow
            switch (index)
            {
                // if the number in index is 1
                // then we will show the alien 1 skin on UFO picture Box
                case 1:
                    ufo.Image = Properties.Resources.alien1;
                    break;
                // if the number in index is 2
                // then we will show the alien 2 skin on UFO picture Box
                case 2:
                    ufo.Image = Properties.Resources.alien2;
                    break;
                // if the number in index is 3
                // then we will show the alien 3 skin on UFO picture Box
                case 3:
                    ufo.Image = Properties.Resources.alien3;
                    break;
            }
        }

        private void makeBullet()
        {
            PictureBox bullet = new PictureBox();
            // create a new picture box class to the form

            bullet.BackColor = System.Drawing.Color.DarkOrange;
            // set the colour of the bullet to dark organge

            bullet.Height = 5;
            // set bullet height to 5 pixels

            bullet.Width = 10;
            // set bullet width to 10 pixels

            bullet.Left = player.Left + player.Width;
            // bullet will place in front of player object

            bullet.Top = player.Top + player.Height / 2;
            // bullet will be middle of player object

            bullet.Tag = "bullet";
            // set the tag for the object to bullet

            this.Controls.Add(bullet);
            // finally adding the picture box bullet to the scene
        }
    }
}
