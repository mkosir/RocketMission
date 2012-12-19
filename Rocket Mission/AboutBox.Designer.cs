namespace Rocket_Mission
{
    partial class AboutBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.aboutOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLblSC = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // aboutOK
            // 
            this.aboutOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.aboutOK.Location = new System.Drawing.Point(195, 179);
            this.aboutOK.Name = "aboutOK";
            this.aboutOK.Size = new System.Drawing.Size(78, 25);
            this.aboutOK.TabIndex = 0;
            this.aboutOK.Text = "OK";
            this.aboutOK.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(267, 166);
            this.textBox1.TabIndex = 5;
            this.textBox1.TabStop = false;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // linkLblSC
            // 
            this.linkLblSC.AutoSize = true;
            this.linkLblSC.Location = new System.Drawing.Point(6, 140);
            this.linkLblSC.Name = "linkLblSC";
            this.linkLblSC.Size = new System.Drawing.Size(66, 13);
            this.linkLblSC.TabIndex = 6;
            this.linkLblSC.TabStop = true;
            this.linkLblSC.Text = "source code";
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.aboutOK;
            this.ClientSize = new System.Drawing.Size(276, 207);
            this.Controls.Add(this.linkLblSC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aboutOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Rocket Mission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aboutOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLblSC;
    }
}