using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Rocket_Mission
{
    public partial class ProfileEditDialog : Form
    {
        #region Properties(DiaYSens, DiaXSens, DiaMaxHoriz, DiaMaxVertic, DiaAstronaut, DiaRocket)
        public double DiaYSens
        {
            get { return Convert.ToDouble(ySensNumeric.Value); }
            set { ySensNumeric.Value = Convert.ToDecimal(value); }
        }
       
        public double DiaXSens
        {
            get { return Convert.ToDouble(xSensNumeric.Value); }
            set { xSensNumeric.Value = Convert.ToDecimal(value); }
        }

        public int DiaMaxHoriz
        {
            get { return Convert.ToInt16(maxHorizNumeric.Value); }
            set { maxHorizNumeric.Value = Convert.ToDecimal(value); }
        }

        public int DiaMaxVertic
        {
            get { return Convert.ToInt16(maxVerticNumeric.Value); }
            set { maxVerticNumeric.Value = Convert.ToDecimal(value); }
        }

        public string DiaAstronaut
        {
            get { return astronautTextBox.Text; }
            set { astronautTextBox.Text = value; }
        }

        public string DiaRocket
        {
            get { return rocketTextBox.Text; }
            set { rocketTextBox.Text = value; }
        }
        #endregion

        #region Constructor(ProfileEditDialog())
        public ProfileEditDialog()
        {
            InitializeComponent();
        }
        #endregion
    }
}