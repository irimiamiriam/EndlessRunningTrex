using EndlessRunning.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EndlessRunning
{
    public partial class Form1 : Form
    {

        bool jumping = false;
        int jumpspeed;
        int force = 12;
        int score = 0;
        int obstaclespeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;


        public Form1()
        {
            InitializeComponent();
            GameReset();

        }

        private void GameReset()
        {
            jumpspeed = 0;
            force = 12;
            score = 0;
            jumping = false;
            obstaclespeed = 10;
            scoretextBox.Text = "Score: " + score;
            trexpictureBox.Image = Resources.running;
            isGameOver = false;
            trexpictureBox.Top = 297;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            gameTimer.Start();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            trexpictureBox.Top += jumpspeed;

            scoretextBox.Text = "Score: " + score;

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpspeed = -12;
                force -= 1;
            }
            else
            {
                jumpspeed = 12;
            }

            if (trexpictureBox.Top > 296 && jumping == false)
            {
                force = 12;
                trexpictureBox.Top = 297;
                jumpspeed = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstaclespeed;

                    if (x.Left < -100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    if (trexpictureBox.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        trexpictureBox.Image = Resources.dead;
                        scoretextBox.Text += " Press R to restart the game!";
                        isGameOver = true;
                    }
                }
            }

            if (score > 5)
            {
                obstaclespeed = 15;
            }
        }


    }
}