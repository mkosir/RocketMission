using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rocket_Mission
{
    public partial class PhysicsDialog : Form
    {
        #region Properties(DiaGravity, DiaMinGravity, DiaMaxGravity, DiaGravityConst, DiaGravFrequency, DiaWind, DiaWindDirection, DiaMedium)
        public double DiaGravity
        {
            get { return Convert.ToDouble(constGravityNumeric.Value); }
            set { constGravityNumeric.Value = Convert.ToDecimal(value); }
        }

        public int DiaMinGravity
        {
            get { return Convert.ToInt32(lowerGravityNumeric.Value); }
            set { lowerGravityNumeric.Value = Convert.ToDecimal(value); }
        }

        public int DiaMaxGravity
        {
            get { return Convert.ToInt32(upperGravityNumeric.Value); }
            set { upperGravityNumeric.Value = Convert.ToDecimal(value); }
        }

        public bool DiaGravityConst
        {
            get { return radioButton1.Checked; }
            set {
                    if (value == true)
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                }
        }

        public string DiaGravFrequency
        {
            get { return gravFreqListBox.Text; }
            set { gravFreqListBox.Text = value; }
        }
        
        public double DiaWind
        {
            get { return Convert.ToDouble(windNumeric.Value); }
            set { windNumeric.Value = Convert.ToDecimal(value); }
        }

        public string DiaWindDirection
        {
            get 
            {
                if (leftDirectionRadio.Checked)
                {
                    return leftDirectionRadio.Text;
                }
                else if (rightDirectionRadio.Checked)
                {
                    return rightDirectionRadio.Text;
                }
                else
                {
                    return randomDirectionRadio.Text;
                }
            }
            set
            {
                if (value == leftDirectionRadio.Text)
                {
                    leftDirectionRadio.Checked = true;
                }
                else if (value == rightDirectionRadio.Text)
                {
                    rightDirectionRadio.Checked = true;
                }
                else
                {
                    randomDirectionRadio.Checked = true;
                }
            }
        }

        public double DiaMedium
        {
            get
            {
                if (vacumRadio.Checked == true)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(thicknessNumeric.Value);
                }
            }
            set 
            {
                if (value == 0)
                {
                    vacumRadio.Checked = true;
                }
                else
                {
                    thicknessRadio.Checked = true;
                    thicknessNumeric.Value = Convert.ToDecimal(value);
                }
            }
        }
        #endregion

        #region Constructor(PhysicsDialog())
        public PhysicsDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers(radioButton1_CheckedChanged(), radioButton2_CheckedChanged(), lowerGravityNumeric_ValueChanged(), upperGravityNumeric_ValueChanged())
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            constGravityNumeric.Enabled = true;
            lowerGravityNumeric.Enabled = false;
            upperGravityNumeric.Enabled = false;
            gravFreqListBox.Enabled = false;
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lowerGravityNumeric.Enabled = true;
            upperGravityNumeric.Enabled = true;
            gravFreqListBox.Enabled = true;
            constGravityNumeric.Enabled = false;
        }

        private void lowerGravityNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (lowerGravityNumeric.Value >= upperGravityNumeric.Value)
            {
                lowerGravityNumeric.Value--;
            }
        }

        private void upperGravityNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (upperGravityNumeric.Value <= lowerGravityNumeric.Value)
            {
                upperGravityNumeric.Value++;
            }
        }

        private void vacumRadio_CheckedChanged(object sender, EventArgs e)
        {
            thicknessNumeric.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void thicknessRadio_CheckedChanged(object sender, EventArgs e)
        {
            thicknessNumeric.Enabled = true;
            groupBox1.Enabled = true;
        }
        #endregion
    }
}