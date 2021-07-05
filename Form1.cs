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

        private void gametick(object sender, EventArgs e)
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

        }
    }
}
