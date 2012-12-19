using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Rocket_Mission
{
    class Rocket
    {
        #region Fields(hasLanded, fuel, rockets, score, xSens, ySens, x, y, xVel, yVel, maxX, maxY)
        private
        //rocket current status
        enum status
        {
            LANDED,
            CRASHED,
            MOVING
        }
        status hasLanded;
        //fuel left
        uint fuel;
        //number of rockets
        uint rockets;
        //current score
        uint score;
        //sensitivity
        double xSens;
        double ySens;
        //current position of a rocket
        double x;
        double y;
        //velocity in x and y direction
        double xVel;
        double yVel;
        //landing limits
        int maxX;
        int maxY;
        #endregion

        #region Constructor(Rocket())
        public Rocket()
        {
            XVel = 0;
            YVel = 0;
            xSens = 1;
            ySens = 1;
            maxX = 3;
            maxY = 5;
            fuel = 100;
            rockets = 3;
            score = 0;
        }
        #endregion

        #region Properties(Fuel, Rockets, Score, XSens, YSens, X, Y, XVel, YVel, MaxX, MaxY)
        public uint Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public uint Rockets
        {
            get { return rockets; }
            set { rockets = value; }
        }

        public uint Score
        {
            get { return score; }
            set { score = value; }
        }

        public double XSens
        {
            get { return xSens; }
            set { xSens = value; }
        }

        public double YSens
        {
            get { return ySens; }
            set { ySens = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double XVel
        {
            get { return xVel; }
            set { xVel = value; }
        }

        public double YVel
        {
            get { return yVel; }
            set { yVel = value; }
        }

        public int MaxX
        {
            get { return maxX; }
            set { maxX = value; }
        }

        public int MaxY
        {
            get { return maxY; }
            set { maxY = value; }
        }
        #endregion

        #region Methods(MoveRocket(), CheckLanding())
        public Point MoveRocket(int formWidht, int formHeight, int picWidth, int picHeight)
        {
            Point location;

            //horizontal position
            x += xVel;
            if (x > formWidht - picWidth)
            {
                x = 0;
            }
            if (x < 0)
            {
                x = Convert.ToDouble(formWidht - picWidth);
            }

            //vertical position
            y += yVel;
            if (y > (formHeight - picHeight - 35))
            {
                y = 24;
            }
            if (y < 24)
            {
                y = Convert.ToDouble(formHeight - picHeight - 35);
            }

            //new location
            location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
            return location;
        }

        public string CheckLanding(Rectangle rocketBounds, Rectangle platformBounds)
        {
            //is there an intersection
            if (rocketBounds.IntersectsWith(platformBounds))
            {
                //check horizontal velocity
                if (Math.Abs(xVel) <= maxX)
                {
                    //check vertical velocity
                    if (Math.Abs(yVel) <= maxY)
                    {
                        if (Math.Abs(rocketBounds.Bottom - platformBounds.Top) < 20)
                        {
                            MessageBox.Show("Congratulation!", "Landed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hasLanded = status.LANDED;
                            return hasLanded.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Ouch", "Crashed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            hasLanded = status.CRASHED;
                            return hasLanded.ToString();
                        }
                    }
                    else
                    {
                        //yVel is too large
                        MessageBox.Show("Maximum vertical velocity exceeded!\n\nVertical Velocity: " + Math.Round(Math.Abs(yVel)) + " pixel/s      Max: " + maxY + " pixel/s", 
                            "Crashed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        hasLanded = status.CRASHED;
                        return hasLanded.ToString();
                    }
                }
                else
                {
                    if (Math.Abs(yVel) >= maxY)
                    {
                        //xVel and yVel are too large
                        MessageBox.Show("Maximum vertical and horizontal velocity exceeded!\n\nVertical Velocity:     " + Math.Round(Math.Abs(yVel)) + " pixel/s      Max: " + maxY + " pixel/s\nHorizontal Velocity: " + Math.Round(Math.Abs(xVel)) + " pixel/s      Max: " + maxX + " pixel/s",
                            "Crashed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        hasLanded = status.CRASHED;
                        return hasLanded.ToString();
                    }
                    else
                    {
                        //xVel is too large
                        MessageBox.Show("Maximum horizontal velocity exceeded!\n\nHorizontal Velocity: " + Math.Round(Math.Abs(xVel)) + " pixel/s      Max: " + maxX + " pixel/s",
                            "Crashed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        hasLanded = status.CRASHED;
                        return hasLanded.ToString();
                    }
                }
            }
            hasLanded = status.MOVING;
            return hasLanded.ToString(); 
        }
        #endregion
    }
}