/***********************************************************************************
This program was made entirely by Marko Kosir, it is freeware,
feel free to use this code or change it in any way you like.
This program is distributed in the hope that it will be useful, 
but WITHOUT ANY WARRANTY; without even the implied warranty 
of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

email: kosir.mar@gmail.com

Tested - Windows XP
Compiled - Microsoft Visual Studio 2005

December 14th, 2006

Upgrade log:
ported to MVS 2010  (23.5.2010)
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Xml;

namespace Rocket_Mission
{
    public partial class MainForm : Form
    {
        #region Fields(level, nameAstronaut, nameRocket, medium, windDirection, windVel, countWind, gravity, gravFrequency, countGravity, pause, errorIntersect, gravityConst, myGravityLimits)
        int level;
        string nameAstronaut;
        string nameRocket;
        double medium; 
        string windDirection;
        double windVel;
        int countWind;
        double gravity;
        string gravFrequency;
        int countGravity;
        bool pause;
        bool errorIntersect;
        bool gravityConst;
        struct gravityLimits
        {
            public int min;
            public int max;
        }
        gravityLimits myGravityLimits;
        #endregion
        
        #region Temporary Fields (for current user settings)
        bool tempGravityConst;
        double tempGravity;
        gravityLimits tempMyGravityLimits;
        string tempGravFrequency;
        double tempMedium;
        double tempWindVel;
        string tempWindDirection;
        int tempMaxX;
        int tempMaxY;
        #endregion

        Rocket Rocket = new Rocket();

        #region Constructor(Form1())
        public MainForm()
        {
            InitializeComponent();
            level = 0;
            nameAstronaut = "";
            nameRocket = "";
            medium = 0;
            windDirection = "Left";
            windVel = 0;
            countWind = 0;
            gravity = 10;
            gravFrequency = "Normal";
            countGravity = 0;
            pause = false;
            errorIntersect = false;
            gravityConst = true;
            myGravityLimits.min = 1;
            myGravityLimits.max = 160;
            tempGravityConst = true;
            tempGravity = 10;
            tempMyGravityLimits.min = 1;
            tempMyGravityLimits.max = 160;
            tempGravFrequency = "Normal";
            tempMedium = 0;
            tempWindVel = 0;
            tempWindDirection = "Left";
            tempMaxX = 3;
            tempMaxY = 5;
        }
        #endregion

        #region Methods(showStats(), gameMode(), killRocket(), setUpMission(bool isMission), cleanUpForm())
        private void showStats()
        {
            double tempXVel;
            double tempYVel;

            tempXVel = Math.Round(Rocket.XVel);
            tempYVel = Math.Round(Rocket.YVel);

            lblXVel.Text = "Vertical Velocity: " + Math.Abs(tempYVel) + " pixel/s";
            lblYVel.Text = "Horizontal Velocity: " + Math.Abs(tempXVel) + " pixel/s";
            lblGravity.Text = "Gravity: " + gravity + " pixel/s2";
            if (medium == 0)
            {
                lblWind.Text = "Wind Velocity: 0 pixel/s";
            }
            else
            {
                lblWind.Text = "Wind Velocity: " + windVel + " pixel/s";
            }
            lblFuel.Text = "Fuel: " + Rocket.Fuel;
            lblRockets.Text = "Rockets: " + Rocket.Rockets;
            lblScore.Text = "Score: " + Rocket.Score;

            #region Show Arrows
            //vertical velocity
            if (tempYVel > 0)
            {
                //show arrow - down
                verticalPictureBox.Image = arrowPics.Images[0];
            }
            else if (tempYVel < 0)
            {
                //show arrow - up
                verticalPictureBox.Image = arrowPics.Images[1];
            }
            else
            {
                //no arrow
                verticalPictureBox.Image = null;

            }
            //horizontal velocity
            if (tempXVel > 0)
            {
                //show arrow - right
                horizontalPictureBox.Image = arrowPics.Images[3];
            }
            else if (tempXVel < 0)
            {
                //show arrow - left
                horizontalPictureBox.Image = arrowPics.Images[2];
            }
            else
            {
                //no arrow
                horizontalPictureBox.Image = null;
            }
            #endregion
        }   

        private void gameMode()
        {
            //normal game mode selected
            if (normalStripMenu.Checked)
            {
                Rocket.XVel = 0;
                Rocket.YVel = 0;
                Rocket.X = ((this.Width / 2) - (rocketPic.Width / 2));
                Rocket.Y = (this.Height / 4);
                platformPic.Location = new Point(((this.Width / 2) - (platformPic.Width / 2)), (this.Height / 2 + this.Height / 3));
            }
            //random game mode selected
            else
            {
                int platX;
                int platY;
                Random random = new Random();
                
                //horizontal and vertical random speed for the rocket
                Rocket.XVel = Convert.ToDouble(random.Next(7));
                Rocket.YVel = Convert.ToDouble(random.Next(7));

                //rocketPic and platformPic intersection
                do
                {
                    //random coordintes for the rocket
                    Rocket.X = random.Next(0, (this.Width - rocketPic.Width));
                    Rocket.Y = random.Next(24, (this.Height - rocketPic.Height - 35));

                    //random coordinates for the platform
                    platX = random.Next(0, (this.Width - platformPic.Width));
                    platY = random.Next(160, (this.Height - platformPic.Height - 35));

                    platformPic.Location = new Point(platX, platY);
                }while(rocketPic.Bounds.IntersectsWith(platformPic.Bounds));
                //timer1_Tick() event handler
                errorIntersect = true;
            }
        }

        private void killRocket()
        {
            if (lblRockets.Visible == true)
            {
                Rocket.Rockets--;
                lblRockets.Text = "Rockets: " + Rocket.Rockets;
            }

            if (Rocket.Rockets <= 0)
            {
                SoundPlayer player = new SoundPlayer(Resources.Sounds.houston);
                player.Load();
                player.Play();

                DialogResult result = MessageBox.Show("Score: " + Rocket.Score.ToString() + "\n\nPlay Again?", "Mission Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Yes)
                {
                    setUpMission(true);
                    return;
                }
                else
                {
                    cleanUpForm();
                    return;
                }
            }
            gameMode();
            timer1.Enabled = true;
        }

        private void setUpMission(bool isMission)
        {
            if (isMission)
            {
                #region Setting Up Mission Environment
                //initialize level
                this.Text = "Rocket Mission - Level 1";
                level = 0;
                gravityConst = true;
                gravity = 10;
                myGravityLimits.min = 1;
                myGravityLimits.max = 160;
                gravFrequency = "Normal";
                medium = 0;
                windVel = 0;
                windDirection = "Left";
                Rocket.MaxX = 4;
                Rocket.MaxY = 7;
                //initialize variables
                Rocket.Fuel = 200;
                Rocket.Score = 0;
                Rocket.Rockets = 3;
                //get user settings
                tempGravityConst = gravityConst;
                tempGravity = gravity;
                tempMyGravityLimits.min = myGravityLimits.min;
                tempMyGravityLimits.max = myGravityLimits.max;
                tempGravFrequency = gravFrequency;
                tempMedium = medium;
                tempWindVel = windVel;
                tempWindDirection = windDirection;
                tempMaxX = Rocket.MaxX;
                tempMaxY = Rocket.MaxY;
                //initialize form
                physicsLoadStripMenu.Enabled = false;
                profilLoadStripMenu.Enabled = false;
                physicsSaveStripMenu.Enabled = false;
                profilSaveStripMenu.Enabled = false;
                normalStripMenu.Enabled = false;
                randomStripMenu.Enabled = false;
                physicsStripMenu.Enabled = false;
                profilEditStripMenu.Enabled = false;
                normalContextMenu.Checked = true;
                randomContextMenu.Checked = false;
                //context menu
                abortStripMenu.Visible = true;
                abortToolStripMenuItem1.Visible = true;
                abortSeparator.Visible = true;
                landingModeToolStripMenuItem.Enabled = false;
                physicsToolStripMenuItem.Enabled = false;
                profileToolStripMenuItem.Enabled = false;
                //make visible all controls
                normalStripMenu.Checked = true;
                randomStripMenu.Checked = false;
                lblScore.Visible = true;
                lblFuel.Visible = true;
                lblRockets.Visible = true;
                #endregion
            }
            else
            {
                #region Setting Up Test Environment
                //set user settings
                gravityConst = tempGravityConst;
                gravity = tempGravity;
                myGravityLimits.min = tempMyGravityLimits.min;
                myGravityLimits.max = tempMyGravityLimits.max;
                gravFrequency = tempGravFrequency;
                medium = tempMedium;
                windVel = tempWindVel;
                windDirection = tempWindDirection;
                Rocket.MaxX = tempMaxX;
                Rocket.MaxY = tempMaxY;
                //initialize form
                physicsLoadStripMenu.Enabled = true;
                profilLoadStripMenu.Enabled = true;
                physicsSaveStripMenu.Enabled = true;
                profilSaveStripMenu.Enabled = true;
                normalStripMenu.Enabled = true;
                randomStripMenu.Enabled = true;
                physicsStripMenu.Enabled = true;
                profilEditStripMenu.Enabled = true;
                this.Text = "Rocket Mission";
                //context menu
                abortStripMenu.Visible = true;
                abortToolStripMenuItem1.Visible = true;
                abortSeparator.Visible = true;
                landingModeToolStripMenuItem.Enabled = true;
                physicsToolStripMenuItem.Enabled = true;
                profileToolStripMenuItem.Enabled = true;
                //make visible just "test" controls        
                lblScore.Visible = false;
                lblFuel.Visible = false;
                lblRockets.Visible = false;
                #endregion
            }
            #region Setting Up Common Controls
            verticalPictureBox.Visible = true;
            horizontalPictureBox.Visible = true;
            windPictureBox.Visible = true;
            rocketPic.Visible = true;
            platformPic.Visible = true;
            lblYVel.Visible = true;
            lblXVel.Visible = true;
            lblGravity.Visible = true;
            lblWind.Visible = true;
            lblFuel.ForeColor = Color.Black;
            #endregion

            //set the game mode
            gameMode();

            //start running timer
            timer1.Enabled = true;
        }

        private void cleanUpForm()
        {
            #region Clean up settings
            lblYVel.Visible = false;
            lblXVel.Visible = false;
            lblGravity.Visible = false;
            lblWind.Visible = false;
            lblFuel.Visible = false;
            lblRockets.Visible = false;
            lblScore.Visible = false;
            rocketPic.Visible = false;
            platformPic.Visible = false;
            verticalPictureBox.Visible = false;
            horizontalPictureBox.Visible = false;
            windPictureBox.Visible = false;
            normalStripMenu.Checked = true;
            randomStripMenu.Checked = false;
            normalContextMenu.Checked = true;
            randomContextMenu.Checked = false;
            this.Text = "Rocket Mission";
            //context menu
            abortStripMenu.Visible = false;
            abortToolStripMenuItem1.Visible = false;
            abortSeparator.Visible = false;
            landingModeToolStripMenuItem.Enabled = true;
            physicsToolStripMenuItem.Enabled = true;
            profileToolStripMenuItem.Enabled = true;
            //load user settings
            gravityConst = tempGravityConst;
            gravity = tempGravity;
            myGravityLimits.min = tempMyGravityLimits.min;
            myGravityLimits.max = tempMyGravityLimits.max;
            gravFrequency = tempGravFrequency;
            medium = tempMedium;
            windVel = tempWindVel;
            windDirection = tempWindDirection;
            Rocket.MaxX = tempMaxX;
            Rocket.MaxY = tempMaxY;
            //initialize form
            physicsLoadStripMenu.Enabled = true;
            profilLoadStripMenu.Enabled = true;
            physicsSaveStripMenu.Enabled = true;
            profilSaveStripMenu.Enabled = true;
            normalStripMenu.Enabled = true;
            randomStripMenu.Enabled = true;
            physicsStripMenu.Enabled = true;
            profilEditStripMenu.Enabled = true;
            lblFuel.ForeColor = Color.Black;
            timer1.Enabled = false;
            #endregion
        }
        #endregion

        #region Event Handlers(Form1_KeyDown(), timer1_Tick(), newStripMenu_Click(), exitToolStripMenuItem1_Click(), normalStripMenu_Click(), randomStripMenu_Click(), physicsStripMenu_Click(), profilEditStripMenu_Click(), Form1_Resize(), rocketNotifyIcon_DoubleClick(), abortStripMenu_Click(), aboutStripMenu_Click(), howToPlayStripMenu_Click())
        #region Key Press
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            #region Fuel Checking
            if (Rocket.Fuel <= 0)
            {   
                //out of fuel
                timer1.Enabled = false;
                lblFuel.Text = "Fuel: 0";
                MessageBox.Show("Out of Fuel!!");
                Rocket.Fuel += 100;
                killRocket();
            }
            if (Rocket.Fuel <= 50)
            {
                //fuel below 50
                lblFuel.ForeColor = Color.Red;
            }
            else
            {
                lblFuel.ForeColor = Color.Black;
            }
            #endregion

            #region Key Press Checking
            if (rocketPic.Visible == true)
            {
                #region Key - Up
                if (e.KeyData == Keys.Up)
                {
                    if (!pause)
                    {
                        rocketPic.Image = rocketPics.Images[1];
                        if (Rocket.YVel >= -160)
                        {
                            Rocket.YVel -= Rocket.YSens;
                            if (Rocket.YVel < -160)
                            {
                                Rocket.YVel = -160;
                            }
                        }
                        if (lblFuel.Visible == true)
                        {
                            Rocket.Fuel--;
                        }
                    }
                }
                #endregion
                #region Key - Right
                else if (e.KeyData == Keys.Right)
                {
                    if (!pause)
                    {
                        rocketPic.Image = rocketPics.Images[3];
                        if (Rocket.XVel >= -160)
                        {
                            Rocket.XVel -= Rocket.XSens;
                            if (Rocket.XVel < -160)
                            {
                                Rocket.XVel = -160;
                            }
                        }
                        if (lblFuel.Visible == true)
                        {
                            Rocket.Fuel--;
                        }
                    }
                }
                #endregion
                #region Key - Left
                else if (e.KeyData == Keys.Left)
                {
                    if (!pause)
                    {
                        rocketPic.Image = rocketPics.Images[2];
                        if (Rocket.XVel <= 160)
                        {
                            Rocket.XVel += Rocket.XSens;
                            if (Rocket.XVel > 160)
                            {
                                Rocket.XVel = 160;
                            }
                        }
                        if (lblFuel.Visible == true)
                        {
                            Rocket.Fuel--;
                        }
                    }
                }
                #endregion
                #region Key - P
                else if (e.KeyData == Keys.P)
                {
                    if (pause == false)
                    {
                        pause = true;
                        timer1.Enabled = false;
                    }
                    else
                    {
                        timer1.Enabled = true;
                        pause = false;
                    }
                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region Game Loop
        private void timer1_Tick(object sender, EventArgs e)
        {
            string hasLanded;
           
            #region Gravity
            //constant gravity selected
            if (gravityConst)
            {
                if (Rocket.YVel <= 160)
                {
                    Rocket.YVel += (gravity / 10);
                    if (Rocket.YVel > 160)
                    {
                        Rocket.YVel = 160;
                    }
                }
            }
            //random gravity selected
            else
            {
                //normal - change gravity every 2s
                if (gravFrequency == "Normal")
                {
                    if (countGravity >= 20 || countGravity == 0)
                    {
                        Random random = new Random();
                        gravity = Convert.ToDouble(random.Next(myGravityLimits.min, myGravityLimits.max));
                        Rocket.YVel += (gravity / 10);
                        countGravity = 0;
                    }
                }

                //slow - change gravity every 4s
                if (gravFrequency == "Slow")
                {
                    if (countGravity >= 40 || countGravity == 0)
                    {
                        Random random = new Random();
                        gravity = Convert.ToDouble(random.Next(myGravityLimits.min, myGravityLimits.max));
                        Rocket.YVel += (gravity / 10);
                        countGravity = 0;
                    }
                }

                //fast - change gravity every 1s
                if (gravFrequency == "Fast")
                {
                    if (countGravity >= 10 || countGravity == 0)
                    {
                        Random random = new Random();
                        gravity = Convert.ToDouble(random.Next(myGravityLimits.min, myGravityLimits.max));
                        Rocket.YVel += (gravity / 10);
                        countGravity = 0;
                    }
                }

                if (Rocket.YVel < 160)
                {
                    Rocket.YVel += (gravity / 10);
                }
                if (Rocket.YVel > 160)
                {
                    Rocket.YVel = 160;
                }
                countGravity++;
            }
            #endregion

            #region Wind
            if (medium > 0)
            {
                //add wind
                if (((windVel > Math.Abs(Rocket.XVel) || (windDirection == "Right" && (windVel > Rocket.XVel)) || (windDirection == "Left" && (Rocket.XVel > 0))) && windVel > 0) || (windDirection == "Random"))
                {
                    if (windDirection == "Left" && (windVel > Math.Abs(Rocket.XVel) || (Rocket.XVel > 0)))
                    {
                        Rocket.XVel -= 0.1;
                        windPictureBox.Image = arrowPics.Images[2];
                    }
                    else if (windDirection == "Right")
                    {
                        Rocket.XVel += 0.1;
                        windPictureBox.Image = arrowPics.Images[3];
                    }
                    else
                    {
                        if (countWind >= 30 || countWind == 0)
                        {
                            Random random = new Random();

                            if (random.Next(Convert.ToInt32(windVel)) < (windVel / 2))
                            {
                                if (windVel > Math.Abs(Rocket.XVel) || (Rocket.XVel > 0))
                                {
                                    Rocket.XVel -= 1;
                                    windPictureBox.Image = arrowPics.Images[2];
                                }
                            }
                            else
                            {
                                if (windVel > Rocket.XVel)
                                {
                                    Rocket.XVel += 1;
                                    windPictureBox.Image = arrowPics.Images[3];
                                }
                            }
                            countWind = 0;
                        }
                        countWind++;
                    }
                }
                //add medium
                if (Math.Round(Rocket.XVel) > Math.Round(windVel))
                {
                    Rocket.XVel -= (medium / 10);
                    if (Rocket.XVel < 1)
                    {
                        Rocket.XVel = Math.Floor(Rocket.XVel);
                    }
                }
                else if ((windDirection == "Left" && (Math.Round(windVel) < Math.Round(Math.Abs(Rocket.XVel)))) || (windDirection == "Right" && Rocket.XVel < 0))
                {
                    Rocket.XVel += (medium / 10);
                    if (Rocket.XVel > -1)
                    {
                        Rocket.XVel = 0;
                    }
                }
            }
            #endregion

            Rocket.X += Rocket.XVel;            
            rocketPic.Image = rocketPics.Images[0];
 
            //update location
            rocketPic.Location = Rocket.MoveRocket(this.Width, this.Height, rocketPic.Width, rocketPic.Height);

            //intersection bettween rocketPic and platformPic
            if (rocketPic.Bounds.IntersectsWith(platformPic.Bounds) && (errorIntersect == true))
            {
                gameMode();
                return;
            }
            errorIntersect = false;

            timer1.Enabled = false;
            showStats();
            hasLanded = Rocket.CheckLanding(rocketPic.Bounds, platformPic.Bounds);
            if (hasLanded == "CRASHED")
            {
                killRocket();
                return;
            }
            else if (hasLanded == "LANDED")
            {
                if (lblScore.Visible == true)
                {
                    #region Levels
                    switch (level)
                    {
                        case 0:
                            Rocket.Score += 1000;
                            Rocket.Fuel += 30;
                            //initialize level
                            this.Text = "Rocket Mission - Level 2";
                            gravityConst = false;
                            gravity = 12;
                            myGravityLimits.min = 1;
                            myGravityLimits.max = 12;
                            gravFrequency = "Normal";
                            medium = 0;
                            windVel = 0;
                            windDirection = "Left";
                            Rocket.MaxX = 4;
                            Rocket.MaxY = 7;
                            break;

                        case 1:
                            this.Text = "Rocket Mission - Level 3";
                            Rocket.Score += 2000;
                            Rocket.Fuel += 30;
                            gravityConst = false;
                            gravity = 15;
                            myGravityLimits.min = 1;
                            myGravityLimits.max = 15;
                            gravFrequency = "Slow";
                            medium = 1;
                            windVel = 8;
                            windDirection = "Random";
                            Rocket.MaxX = 5;
                            Rocket.MaxY = 7;
                            break;

                        case 2:
                            this.Text = "Rocket Mission - Level 4";
                            Rocket.Score += 3000;
                            Rocket.Fuel += 30;
                            gravityConst = false;
                            gravity = 15;
                            myGravityLimits.min = 1;
                            myGravityLimits.max = 15;
                            gravFrequency = "Slow";
                            medium = 1;
                            windVel = 6;
                            windDirection = "Left";
                            Rocket.MaxX = 5;
                            Rocket.MaxY = 7;
                            break;

                        case 3:
                            Rocket.Score += 4000;
                            lblScore.Text = "Score: " + Rocket.Score;
                            SoundPlayer player = new SoundPlayer(Resources.Sounds.smallStep);
                            player.Load();
                            player.Play();
                            DialogResult result = MessageBox.Show("Score: " + Rocket.Score.ToString() + "\n\nPlay Again?", "Mission Comlete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                            if (result == DialogResult.Yes)
                            {
                                setUpMission(true);
                            }
                            else
                            {
                                cleanUpForm();
                                return;
                            }
                            break;

                        default:
                            break;
                    }
                    level++;
                    #endregion
                }
                gameMode();
            }
            timer1.Enabled = true;

            showStats();
        }
        #endregion

        #region Menus
        private void newStripMenu_Click(object sender, EventArgs e)
        {
            setUpMission(true);
        }

        private void testLaunchStripMenu_Click(object sender, EventArgs e)
        {
            setUpMission(false);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void normalStripMenu_Click(object sender, EventArgs e)
        {
            //menu
            normalStripMenu.Checked = true;
            randomStripMenu.Checked = false;
            //context menu
            normalContextMenu.Checked = true;
            randomContextMenu.Checked = false;
        }

        private void randomStripMenu_Click(object sender, EventArgs e)
        {
            //menus
            normalStripMenu.Checked = false;
            randomStripMenu.Checked = true;
            //context menu
            normalContextMenu.Checked = false;
            randomContextMenu.Checked = true;
        }

        private void physicsStripMenu_Click(object sender, EventArgs e)
        {
            PhysicsDialog physics = new PhysicsDialog();

            //update physics dialog
            physics.DiaGravity = gravity;
            physics.DiaMinGravity = myGravityLimits.min;
            physics.DiaMaxGravity = myGravityLimits.max;
            physics.DiaGravityConst = gravityConst;
            physics.DiaWind = windVel;
            physics.DiaWindDirection = windDirection;
            physics.DiaGravFrequency = gravFrequency;
            physics.DiaMedium = medium;

            DialogResult result = physics.ShowDialog();
            if (result == DialogResult.OK)
            {
                //update fields
                gravity = physics.DiaGravity;
                myGravityLimits.min = physics.DiaMinGravity;
                myGravityLimits.max = physics.DiaMaxGravity;
                gravFrequency = physics.DiaGravFrequency;
                windVel = physics.DiaWind;
                windDirection = physics.DiaWindDirection;
                medium = physics.DiaMedium;
                tempGravity = physics.DiaGravity;
                tempMyGravityLimits.min = physics.DiaMinGravity;
                tempMyGravityLimits.max = physics.DiaMaxGravity;
                tempGravFrequency = physics.DiaGravFrequency;
                tempMedium = physics.DiaMedium;
                tempWindVel = physics.DiaWind;
                tempWindDirection = physics.DiaWindDirection;

                if (physics.DiaGravityConst)
                {
                    gravityConst = true;
                    tempGravityConst = true;
                }
                else
                {
                    gravityConst = false;
                    tempGravityConst = false;
                }
            }
        }
        
        private void profilEditStripMenu_Click(object sender, EventArgs e)
        {
            ProfileEditDialog profile = new ProfileEditDialog();

            //update profile dialog
            profile.DiaYSens = Rocket.YSens;
            profile.DiaXSens = Rocket.XSens;
            profile.DiaMaxHoriz = Rocket.MaxX;
            profile.DiaMaxVertic = Rocket.MaxY;
            profile.DiaAstronaut = nameAstronaut;
            profile.DiaRocket = nameRocket;

            DialogResult result = profile.ShowDialog();
            if (result == DialogResult.OK)
            {
                //update fields
                Rocket.YSens = profile.DiaYSens;
                Rocket.XSens = profile.DiaXSens;
                Rocket.MaxX = profile.DiaMaxHoriz;
                Rocket.MaxY = profile.DiaMaxVertic;
                nameAstronaut = profile.DiaAstronaut;
                nameRocket = profile.DiaRocket;
                tempMaxX = profile.DiaMaxHoriz;
                tempMaxY = profile.DiaMaxVertic;
            }
        }

        private void abortStripMenu_Click(object sender, EventArgs e)
        {
            cleanUpForm();
        }

        private void aboutStripMenu_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
        #endregion

        #region Notify Icon
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                this.rocketNotifyIcon.Visible = true;
            }
        }

        private void rocketNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.rocketNotifyIcon.Visible = false;
            this.Show();
            WindowState = FormWindowState.Normal;
        }
        #endregion

        #endregion

        #region Load&Save Event Handlers - XML

        //I decided to use XmlDocument class, since XML documents for profile and physics aren't very large.
        //To keep things simple I didn't use XML schema, instead I just added verification string.

        #region Load XML
        #region Load Physics
        private void physicsLoadStripMenu_Click(object sender, EventArgs e)
        {
            //create open file dialog
            openFileDialog1.Title = "Load Physics";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //XmlDocument instance
                XmlDocument xmlDoc = new XmlDocument();

                //load xml document
                try
                {
                    xmlDoc.Load(openFileDialog1.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return;
                }

                //check if the file is correct
                XmlNode checkNode = xmlDoc.SelectSingleNode("/physics/gravity[@id='hl2wej7sa9faper4ovf3sdns']");
                if (checkNode != null)
                {
                    //child nodes (gravity)
                    XmlNodeList gravityNodeList = xmlDoc.SelectNodes("/physics/gravity/*");
                    gravityConst = Convert.ToBoolean(gravityNodeList[0].InnerText);
                    gravity = Convert.ToDouble(gravityNodeList[1].InnerText);
                    myGravityLimits.min = Convert.ToInt16(gravityNodeList[2].InnerText);
                    myGravityLimits.max = Convert.ToInt16(gravityNodeList[3].InnerText);
                    gravFrequency = gravityNodeList[4].InnerText;

                    //child nodes (medium)
                    XmlNodeList mediumNodeList = xmlDoc.SelectNodes("/physics/medium/*");
                    medium = Convert.ToDouble(mediumNodeList[0].InnerText);

                    //child nodes (wind)
                    XmlNodeList windNodeList = xmlDoc.SelectNodes("/physics/wind/*");
                    windVel = Convert.ToDouble(windNodeList[0].InnerText);
                    windDirection = windNodeList[1].InnerText;
                }
                else
                {
                    MessageBox.Show("Physics can not be loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region Load Profile
        private void profilLoadStripMenu_Click(object sender, EventArgs e)
        {
            //create open file dialog
            openFileDialog1.Title = "Load Profile";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //XmlDocument instance
                XmlDocument xmlDoc = new XmlDocument();

                //load xml document
                try
                {
                    xmlDoc.Load(openFileDialog1.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return;
                }

                //check if the file is correct
                XmlNode checkNode = xmlDoc.SelectSingleNode("/profile/user[@id='hf5pw1abnd6keagk4sejs']");
                if (checkNode != null)
                {
                    //child nodes (user)
                    XmlNodeList userNodeList = xmlDoc.SelectNodes("/profile/user/*");
                    nameAstronaut = userNodeList[0].InnerText;
                    nameRocket = userNodeList[1].InnerText;

                    //child nodes (landing limit)
                    XmlNodeList landLimNodeList = xmlDoc.SelectNodes("/profile/landingLimits/*");
                    Rocket.MaxX = Convert.ToInt16(landLimNodeList[0].InnerText);
                    Rocket.MaxY = Convert.ToInt16(landLimNodeList[1].InnerText);

                    //child nodes (controls sensibility)
                    XmlNodeList contSensNodeList = xmlDoc.SelectNodes("/profile/controlsSensibility/*");
                    Rocket.XSens = Convert.ToInt16(contSensNodeList[0].InnerText);
                    Rocket.YSens = Convert.ToInt16(contSensNodeList[1].InnerText);

                    ////if you are more comfortable working with XmlElement than with XPath here is an alternative
                    ////XmlElement instance for browsing the xml file
                    //XmlElement xmlElement = xmlDoc.DocumentElement;

                    //xmlElement = (XmlElement)xmlElement.FirstChild;
                    //nameAstronaut = xmlElement.FirstChild.InnerText;
                    //nameRocket = xmlElement.LastChild.InnerText;

                    //xmlElement = (XmlElement)xmlElement.NextSibling;
                    //Rocket.MaxX = Convert.ToInt16(xmlElement.FirstChild.InnerText);
                    //Rocket.MaxY = Convert.ToInt16(xmlElement.LastChild.InnerText);

                    //xmlElement = (XmlElement)xmlElement.NextSibling;
                    //Rocket.XSens = Convert.ToInt16(xmlElement.FirstChild.InnerText);
                    //Rocket.YSens = Convert.ToInt16(xmlElement.LastChild.InnerText);
                }
                else
                {
                    MessageBox.Show("Profile can not be loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion
        #endregion

        #region Save XML
        #region Save Physics
        private void physicsSaveStripMenu_Click(object sender, EventArgs e)
        {
            //create save file dialog
            saveFileDialog1.Title = "Save Physics";
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //XmlDocument instance
                XmlDocument xmlDoc = new XmlDocument();

                //XmlNode instance for manipulating the xml file
                XmlNode xmlDocNode = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.AppendChild(xmlDocNode);

                //create the root element
                XmlNode physicsNode = xmlDoc.CreateElement("physics");
                xmlDoc.AppendChild(physicsNode);

                //create a nested element (gravity)
                XmlNode gravityNode = xmlDoc.CreateElement("gravity");
                XmlAttribute gravityAttribute = xmlDoc.CreateAttribute("id");
                gravityAttribute.Value = "hl2wej7sa9faper4ovf3sdns";
                gravityNode.Attributes.Append(gravityAttribute);
                physicsNode.AppendChild(gravityNode);

                //create a nested element (isConstant)
                XmlNode isConstNode = xmlDoc.CreateElement("isConstant");
                isConstNode.AppendChild(xmlDoc.CreateTextNode(gravityConst.ToString()));
                gravityNode.AppendChild(isConstNode);

                //create a nested element (gravity value)
                XmlNode graValueNode = xmlDoc.CreateElement("gravityValue");
                graValueNode.AppendChild(xmlDoc.CreateTextNode(gravity.ToString()));
                gravityNode.AppendChild(graValueNode);

                //create a nested element (lower gravity limit)
                XmlNode lowGraLimNode = xmlDoc.CreateElement("lowerGravityLimit");
                lowGraLimNode.AppendChild(xmlDoc.CreateTextNode(myGravityLimits.min.ToString()));
                gravityNode.AppendChild(lowGraLimNode);

                //create a nested element (upper gravity limit)
                XmlNode upGraLimNode = xmlDoc.CreateElement("upperGravityLimit");
                upGraLimNode.AppendChild(xmlDoc.CreateTextNode(myGravityLimits.max.ToString()));
                gravityNode.AppendChild(upGraLimNode);

                //create a nested element (gravity frequency)
                XmlNode gravFreqNode = xmlDoc.CreateElement("gravityFrequency");
                gravFreqNode.AppendChild(xmlDoc.CreateTextNode(gravFrequency));
                gravityNode.AppendChild(gravFreqNode);

                //create a nested element (medium)
                XmlNode mediumNode = xmlDoc.CreateElement("medium");
                physicsNode.AppendChild(mediumNode);

                //create a nested element (density)
                XmlNode densityNode = xmlDoc.CreateElement("density");
                densityNode.AppendChild(xmlDoc.CreateTextNode(medium.ToString()));
                mediumNode.AppendChild(densityNode);

                //create a nested element (wind)
                XmlNode windNode = xmlDoc.CreateElement("wind");
                physicsNode.AppendChild(windNode);

                //create a nested element (velocity)
                XmlNode velocityNode = xmlDoc.CreateElement("velocity");
                velocityNode.AppendChild(xmlDoc.CreateTextNode(windVel.ToString()));
                windNode.AppendChild(velocityNode);

                //create a nested element (direction)
                XmlNode directionNode = xmlDoc.CreateElement("direction");
                directionNode.AppendChild(xmlDoc.CreateTextNode(windDirection));
                windNode.AppendChild(directionNode);

                //save the xml document
                try
                {
                    xmlDoc.Save(saveFileDialog1.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return;
                }
            }
        }
        #endregion

        #region Save Profile
        private void profilSaveStripMenu_Click(object sender, EventArgs e)
        {
            //create save file dialog
            saveFileDialog1.Title = "Save Profile";
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //XmlDocument instance
                XmlDocument xmlDoc = new XmlDocument();

                //XmlNode instance for manipulating the xml file
                XmlNode xmlDocNode = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.AppendChild(xmlDocNode);

                //create the root element
                XmlNode profileNode = xmlDoc.CreateElement("profile");
                xmlDoc.AppendChild(profileNode);

                //create a nested element (user)
                XmlNode userNode = xmlDoc.CreateElement("user");
                XmlAttribute userAttribute = xmlDoc.CreateAttribute("id");
                userAttribute.Value = "hf5pw1abnd6keagk4sejs";
                userNode.Attributes.Append(userAttribute);
                profileNode.AppendChild(userNode);

                //create a nested element (astronaut)
                XmlNode astronautNode = xmlDoc.CreateElement("astronaut");
                if (nameAstronaut == "")
                {
                    astronautNode.AppendChild(xmlDoc.CreateTextNode("Space Cowboy"));
                }
                else
                {
                    astronautNode.AppendChild(xmlDoc.CreateTextNode(nameAstronaut));
                }
                userNode.AppendChild(astronautNode);

                //create a nested element (rocket)
                XmlNode rocketNode = xmlDoc.CreateElement("rocket");
                if (nameRocket == "")
                {
                    rocketNode.AppendChild(xmlDoc.CreateTextNode("Betty"));
                }
                else
                {
                    rocketNode.AppendChild(xmlDoc.CreateTextNode(nameRocket));
                }
                userNode.AppendChild(rocketNode);

                //create a nested element (landing limits)
                XmlNode landLimNode = xmlDoc.CreateElement("landingLimits");
                profileNode.AppendChild(landLimNode);

                //create a nested element (max horizontal velocity)
                XmlNode maxXVelNode = xmlDoc.CreateElement("maxXVelocity");
                maxXVelNode.AppendChild(xmlDoc.CreateTextNode(Rocket.MaxX.ToString()));
                landLimNode.AppendChild(maxXVelNode);

                //create a nested element (max vertical velocity)
                XmlNode maxYVelNode = xmlDoc.CreateElement("maxYVelocity");
                maxYVelNode.AppendChild(xmlDoc.CreateTextNode(Rocket.MaxY.ToString()));
                landLimNode.AppendChild(maxYVelNode);

                //create a nested element (controls sensibility)
                XmlNode contSensNode = xmlDoc.CreateElement("controlsSensibility");
                profileNode.AppendChild(contSensNode);

                //create a nested element (horizontal sensibility)
                XmlNode xSensNode = xmlDoc.CreateElement("xSensibility");
                xSensNode.AppendChild(xmlDoc.CreateTextNode(Rocket.XSens.ToString()));
                contSensNode.AppendChild(xSensNode);

                //create a nested element (vertical sensibility)
                XmlNode ySensNode = xmlDoc.CreateElement("ySensibility");
                ySensNode.AppendChild(xmlDoc.CreateTextNode(Rocket.YSens.ToString()));
                contSensNode.AppendChild(ySensNode);

                //save the xml document
                try
                {
                    xmlDoc.Save(saveFileDialog1.FileName);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return;
                }
            }
        }
        #endregion
        #endregion

        #endregion
    }
}