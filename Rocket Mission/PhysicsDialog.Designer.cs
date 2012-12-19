namespace Rocket_Mission
{
    partial class PhysicsDialog
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
            this.physicsOK = new System.Windows.Forms.Button();
            this.physicsCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomDirectionRadio = new System.Windows.Forms.RadioButton();
            this.rightDirectionRadio = new System.Windows.Forms.RadioButton();
            this.leftDirectionRadio = new System.Windows.Forms.RadioButton();
            this.windNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gravFreqListBox = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.upperGravityNumeric = new System.Windows.Forms.NumericUpDown();
            this.lowerGravityNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.constGravityNumeric = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.thicknessNumeric = new System.Windows.Forms.NumericUpDown();
            this.thicknessRadio = new System.Windows.Forms.RadioButton();
            this.vacumRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperGravityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerGravityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constGravityNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // physicsOK
            // 
            this.physicsOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.physicsOK.Location = new System.Drawing.Point(21, 428);
            this.physicsOK.Name = "physicsOK";
            this.physicsOK.Size = new System.Drawing.Size(78, 25);
            this.physicsOK.TabIndex = 3;
            this.physicsOK.Text = "OK";
            this.physicsOK.UseVisualStyleBackColor = true;
            // 
            // physicsCancel
            // 
            this.physicsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.physicsCancel.Location = new System.Drawing.Point(152, 428);
            this.physicsCancel.Name = "physicsCancel";
            this.physicsCancel.Size = new System.Drawing.Size(78, 25);
            this.physicsCancel.TabIndex = 4;
            this.physicsCancel.Text = "Cancel";
            this.physicsCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gravity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "pixel/s";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "pixel/s";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.randomDirectionRadio);
            this.groupBox1.Controls.Add(this.rightDirectionRadio);
            this.groupBox1.Controls.Add(this.leftDirectionRadio);
            this.groupBox1.Controls.Add(this.windNumeric);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wind";
            // 
            // randomDirectionRadio
            // 
            this.randomDirectionRadio.AutoSize = true;
            this.randomDirectionRadio.Location = new System.Drawing.Point(65, 101);
            this.randomDirectionRadio.Name = "randomDirectionRadio";
            this.randomDirectionRadio.Size = new System.Drawing.Size(65, 17);
            this.randomDirectionRadio.TabIndex = 3;
            this.randomDirectionRadio.Text = "Random";
            this.randomDirectionRadio.UseVisualStyleBackColor = true;
            // 
            // rightDirectionRadio
            // 
            this.rightDirectionRadio.AutoSize = true;
            this.rightDirectionRadio.Location = new System.Drawing.Point(65, 78);
            this.rightDirectionRadio.Name = "rightDirectionRadio";
            this.rightDirectionRadio.Size = new System.Drawing.Size(50, 17);
            this.rightDirectionRadio.TabIndex = 2;
            this.rightDirectionRadio.Text = "Right";
            this.rightDirectionRadio.UseVisualStyleBackColor = true;
            // 
            // leftDirectionRadio
            // 
            this.leftDirectionRadio.AutoSize = true;
            this.leftDirectionRadio.Checked = true;
            this.leftDirectionRadio.Location = new System.Drawing.Point(65, 55);
            this.leftDirectionRadio.Name = "leftDirectionRadio";
            this.leftDirectionRadio.Size = new System.Drawing.Size(43, 17);
            this.leftDirectionRadio.TabIndex = 1;
            this.leftDirectionRadio.TabStop = true;
            this.leftDirectionRadio.Text = "Left";
            this.leftDirectionRadio.UseVisualStyleBackColor = true;
            // 
            // windNumeric
            // 
            this.windNumeric.Location = new System.Drawing.Point(55, 23);
            this.windNumeric.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.windNumeric.Name = "windNumeric";
            this.windNumeric.Size = new System.Drawing.Size(38, 20);
            this.windNumeric.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Direction:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gravFreqListBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.upperGravityNumeric);
            this.groupBox3.Controls.Add(this.lowerGravityNumeric);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.constGravityNumeric);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 196);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gravity";
            // 
            // gravFreqListBox
            // 
            this.gravFreqListBox.Enabled = false;
            this.gravFreqListBox.FormattingEnabled = true;
            this.gravFreqListBox.Items.AddRange(new object[] {
            "Slow",
            "Normal",
            "Fast"});
            this.gravFreqListBox.Location = new System.Drawing.Point(138, 160);
            this.gravFreqListBox.Name = "gravFreqListBox";
            this.gravFreqListBox.Size = new System.Drawing.Size(56, 30);
            this.gravFreqListBox.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Gravity Frequency:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(210, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "pixel/s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(210, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "pixel/s";
            // 
            // upperGravityNumeric
            // 
            this.upperGravityNumeric.Enabled = false;
            this.upperGravityNumeric.Location = new System.Drawing.Point(138, 130);
            this.upperGravityNumeric.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.upperGravityNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.upperGravityNumeric.Name = "upperGravityNumeric";
            this.upperGravityNumeric.ReadOnly = true;
            this.upperGravityNumeric.Size = new System.Drawing.Size(38, 20);
            this.upperGravityNumeric.TabIndex = 4;
            this.upperGravityNumeric.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.upperGravityNumeric.ValueChanged += new System.EventHandler(this.upperGravityNumeric_ValueChanged);
            // 
            // lowerGravityNumeric
            // 
            this.lowerGravityNumeric.Enabled = false;
            this.lowerGravityNumeric.Location = new System.Drawing.Point(138, 105);
            this.lowerGravityNumeric.Maximum = new decimal(new int[] {
            159,
            0,
            0,
            0});
            this.lowerGravityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lowerGravityNumeric.Name = "lowerGravityNumeric";
            this.lowerGravityNumeric.ReadOnly = true;
            this.lowerGravityNumeric.Size = new System.Drawing.Size(38, 20);
            this.lowerGravityNumeric.TabIndex = 3;
            this.lowerGravityNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lowerGravityNumeric.ValueChanged += new System.EventHandler(this.lowerGravityNumeric_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lower Gravity Limit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Upper Gravity Limit:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(155, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "2";
            // 
            // constGravityNumeric
            // 
            this.constGravityNumeric.Location = new System.Drawing.Point(84, 47);
            this.constGravityNumeric.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.constGravityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.constGravityNumeric.Name = "constGravityNumeric";
            this.constGravityNumeric.Size = new System.Drawing.Size(38, 20);
            this.constGravityNumeric.TabIndex = 1;
            this.constGravityNumeric.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Random";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Constant";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.thicknessNumeric);
            this.groupBox2.Controls.Add(this.thicknessRadio);
            this.groupBox2.Controls.Add(this.vacumRadio);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medium";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(136, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 12);
            this.label15.TabIndex = 15;
            this.label15.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(102, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "pixel/s";
            // 
            // thicknessNumeric
            // 
            this.thicknessNumeric.Enabled = false;
            this.thicknessNumeric.Location = new System.Drawing.Point(69, 43);
            this.thicknessNumeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.thicknessNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessNumeric.Name = "thicknessNumeric";
            this.thicknessNumeric.Size = new System.Drawing.Size(32, 20);
            this.thicknessNumeric.TabIndex = 2;
            this.thicknessNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // thicknessRadio
            // 
            this.thicknessRadio.AutoSize = true;
            this.thicknessRadio.Location = new System.Drawing.Point(8, 43);
            this.thicknessRadio.Name = "thicknessRadio";
            this.thicknessRadio.Size = new System.Drawing.Size(63, 17);
            this.thicknessRadio.TabIndex = 1;
            this.thicknessRadio.Text = "Density:";
            this.thicknessRadio.UseVisualStyleBackColor = true;
            this.thicknessRadio.CheckedChanged += new System.EventHandler(this.thicknessRadio_CheckedChanged);
            // 
            // vacumRadio
            // 
            this.vacumRadio.AutoSize = true;
            this.vacumRadio.Checked = true;
            this.vacumRadio.Location = new System.Drawing.Point(8, 20);
            this.vacumRadio.Name = "vacumRadio";
            this.vacumRadio.Size = new System.Drawing.Size(64, 17);
            this.vacumRadio.TabIndex = 0;
            this.vacumRadio.TabStop = true;
            this.vacumRadio.Text = "Vacuum";
            this.vacumRadio.UseVisualStyleBackColor = true;
            this.vacumRadio.CheckedChanged += new System.EventHandler(this.vacumRadio_CheckedChanged);
            // 
            // PhysicsDialog
            // 
            this.AcceptButton = this.physicsOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.physicsCancel;
            this.ClientSize = new System.Drawing.Size(252, 459);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.physicsCancel);
            this.Controls.Add(this.physicsOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhysicsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Physics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperGravityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerGravityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constGravityNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button physicsOK;
        private System.Windows.Forms.Button physicsCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown constGravityNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown upperGravityNumeric;
        private System.Windows.Forms.NumericUpDown lowerGravityNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown windNumeric;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton randomDirectionRadio;
        private System.Windows.Forms.RadioButton rightDirectionRadio;
        private System.Windows.Forms.RadioButton leftDirectionRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton vacumRadio;
        private System.Windows.Forms.NumericUpDown thicknessNumeric;
        private System.Windows.Forms.RadioButton thicknessRadio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox gravFreqListBox;
    }
}