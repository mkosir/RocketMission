namespace Rocket_Mission
{
    partial class ProfileEditDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profileOK = new System.Windows.Forms.Button();
            this.profileCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ySensNumeric = new System.Windows.Forms.NumericUpDown();
            this.xSensNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rocketTextBox = new System.Windows.Forms.TextBox();
            this.astronautTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxVerticNumeric = new System.Windows.Forms.NumericUpDown();
            this.maxHorizNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ySensNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSensNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxVerticNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHorizNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // profileOK
            // 
            this.profileOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.profileOK.Location = new System.Drawing.Point(21, 263);
            this.profileOK.Name = "profileOK";
            this.profileOK.Size = new System.Drawing.Size(78, 25);
            this.profileOK.TabIndex = 3;
            this.profileOK.Text = "OK";
            this.profileOK.UseVisualStyleBackColor = true;
            // 
            // profileCancel
            // 
            this.profileCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.profileCancel.Location = new System.Drawing.Point(136, 263);
            this.profileCancel.Name = "profileCancel";
            this.profileCancel.Size = new System.Drawing.Size(78, 25);
            this.profileCancel.TabIndex = 4;
            this.profileCancel.Text = "Cancel";
            this.profileCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ySensNumeric);
            this.groupBox2.Controls.Add(this.xSensNumeric);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls Sensibility";
            // 
            // ySensNumeric
            // 
            this.ySensNumeric.Location = new System.Drawing.Point(112, 46);
            this.ySensNumeric.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.ySensNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ySensNumeric.Name = "ySensNumeric";
            this.ySensNumeric.Size = new System.Drawing.Size(38, 20);
            this.ySensNumeric.TabIndex = 1;
            this.ySensNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xSensNumeric
            // 
            this.xSensNumeric.Location = new System.Drawing.Point(112, 19);
            this.xSensNumeric.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.xSensNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xSensNumeric.Name = "xSensNumeric";
            this.xSensNumeric.Size = new System.Drawing.Size(38, 20);
            this.xSensNumeric.TabIndex = 0;
            this.xSensNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "pixel/press";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "pixel/press";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Vertical Sensibility:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horizontal Sensibility:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rocketTextBox);
            this.groupBox1.Controls.Add(this.astronautTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // rocketTextBox
            // 
            this.rocketTextBox.Location = new System.Drawing.Point(72, 45);
            this.rocketTextBox.Name = "rocketTextBox";
            this.rocketTextBox.Size = new System.Drawing.Size(127, 20);
            this.rocketTextBox.TabIndex = 1;
            // 
            // astronautTextBox
            // 
            this.astronautTextBox.Location = new System.Drawing.Point(72, 19);
            this.astronautTextBox.Name = "astronautTextBox";
            this.astronautTextBox.Size = new System.Drawing.Size(127, 20);
            this.astronautTextBox.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Rocket:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Astronaut:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.maxVerticNumeric);
            this.groupBox3.Controls.Add(this.maxHorizNumeric);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 71);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Landing Limits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "pixel/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "pixel/s";
            // 
            // maxVerticNumeric
            // 
            this.maxVerticNumeric.Location = new System.Drawing.Point(126, 45);
            this.maxVerticNumeric.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.maxVerticNumeric.Name = "maxVerticNumeric";
            this.maxVerticNumeric.Size = new System.Drawing.Size(38, 20);
            this.maxVerticNumeric.TabIndex = 1;
            this.maxVerticNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // maxHorizNumeric
            // 
            this.maxHorizNumeric.Location = new System.Drawing.Point(126, 19);
            this.maxHorizNumeric.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.maxHorizNumeric.Name = "maxHorizNumeric";
            this.maxHorizNumeric.Size = new System.Drawing.Size(38, 20);
            this.maxHorizNumeric.TabIndex = 0;
            this.maxHorizNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Max Vertical Velocity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max Horizontal Velocity:";
            // 
            // ProfileEditDialog
            // 
            this.AcceptButton = this.profileOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.profileCancel;
            this.ClientSize = new System.Drawing.Size(233, 295);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.profileCancel);
            this.Controls.Add(this.profileOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileEditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ySensNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSensNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxVerticNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxHorizNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profileOK;
        private System.Windows.Forms.Button profileCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown ySensNumeric;
        private System.Windows.Forms.NumericUpDown xSensNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxVerticNumeric;
        private System.Windows.Forms.NumericUpDown maxHorizNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox astronautTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rocketTextBox;
    }
}