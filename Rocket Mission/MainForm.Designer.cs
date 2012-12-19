namespace Rocket_Mission
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblXVel = new System.Windows.Forms.Label();
            this.lblYVel = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblRockets = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testLaunchStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.abortStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loadStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsLoadStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.profilLoadStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsSaveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.profilSaveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameModeStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.normalStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.randomStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.physicsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.profilEditStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rocketPics = new System.Windows.Forms.ImageList(this.components);
            this.lblGravity = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.platformPic = new System.Windows.Forms.PictureBox();
            this.rocketPic = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abortSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.landingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.randomContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.physicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalPictureBox = new System.Windows.Forms.PictureBox();
            this.arrowPics = new System.Windows.Forms.ImageList(this.components);
            this.horizontalPictureBox = new System.Windows.Forms.PictureBox();
            this.windPictureBox = new System.Windows.Forms.PictureBox();
            this.rocketNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platformPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketPic)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windPictureBox)).BeginInit();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblXVel
            // 
            this.lblXVel.AutoSize = true;
            this.lblXVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXVel.Location = new System.Drawing.Point(12, 36);
            this.lblXVel.Name = "lblXVel";
            this.lblXVel.Size = new System.Drawing.Size(112, 15);
            this.lblXVel.TabIndex = 0;
            this.lblXVel.Text = "Vertical Velocity:";
            this.lblXVel.Visible = false;
            // 
            // lblYVel
            // 
            this.lblYVel.AutoSize = true;
            this.lblYVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYVel.Location = new System.Drawing.Point(12, 58);
            this.lblYVel.Name = "lblYVel";
            this.lblYVel.Size = new System.Drawing.Size(130, 15);
            this.lblYVel.TabIndex = 1;
            this.lblYVel.Text = "Horizontal Velocity:";
            this.lblYVel.Visible = false;
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFuel.Location = new System.Drawing.Point(12, 122);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(39, 15);
            this.lblFuel.TabIndex = 2;
            this.lblFuel.Text = "Fuel:";
            this.lblFuel.Visible = false;
            // 
            // lblRockets
            // 
            this.lblRockets.AutoSize = true;
            this.lblRockets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRockets.Location = new System.Drawing.Point(12, 144);
            this.lblRockets.Name = "lblRockets";
            this.lblRockets.Size = new System.Drawing.Size(62, 15);
            this.lblRockets.TabIndex = 3;
            this.lblRockets.Text = "Rockets:";
            this.lblRockets.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.Location = new System.Drawing.Point(12, 166);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(48, 15);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            this.lblScore.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.dToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testLaunchStripMenu,
            this.newStripMenu,
            this.abortStripMenu,
            this.toolStripSeparator3,
            this.loadStripMenu,
            this.saveStripMenu,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.gameToolStripMenuItem.Text = "&New";
            // 
            // testLaunchStripMenu
            // 
            this.testLaunchStripMenu.Name = "testLaunchStripMenu";
            this.testLaunchStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.testLaunchStripMenu.Size = new System.Drawing.Size(181, 22);
            this.testLaunchStripMenu.Text = "&Test Launch";
            this.testLaunchStripMenu.Click += new System.EventHandler(this.testLaunchStripMenu_Click);
            // 
            // newStripMenu
            // 
            this.newStripMenu.Name = "newStripMenu";
            this.newStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.newStripMenu.Size = new System.Drawing.Size(181, 22);
            this.newStripMenu.Text = "&Mission";
            this.newStripMenu.Click += new System.EventHandler(this.newStripMenu_Click);
            // 
            // abortStripMenu
            // 
            this.abortStripMenu.Name = "abortStripMenu";
            this.abortStripMenu.Size = new System.Drawing.Size(181, 22);
            this.abortStripMenu.Text = "&Abort";
            this.abortStripMenu.Visible = false;
            this.abortStripMenu.Click += new System.EventHandler(this.abortStripMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // loadStripMenu
            // 
            this.loadStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.physicsLoadStripMenu,
            this.profilLoadStripMenu});
            this.loadStripMenu.Image = global::Rocket_Mission.Properties.Resources.openfolder;
            this.loadStripMenu.Name = "loadStripMenu";
            this.loadStripMenu.Size = new System.Drawing.Size(181, 22);
            this.loadStripMenu.Text = "&Load";
            // 
            // physicsLoadStripMenu
            // 
            this.physicsLoadStripMenu.Image = global::Rocket_Mission.Properties.Resources.physics;
            this.physicsLoadStripMenu.Name = "physicsLoadStripMenu";
            this.physicsLoadStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.physicsLoadStripMenu.Size = new System.Drawing.Size(154, 22);
            this.physicsLoadStripMenu.Text = "&Physics";
            this.physicsLoadStripMenu.Click += new System.EventHandler(this.physicsLoadStripMenu_Click);
            // 
            // profilLoadStripMenu
            // 
            this.profilLoadStripMenu.Image = global::Rocket_Mission.Properties.Resources.userL;
            this.profilLoadStripMenu.Name = "profilLoadStripMenu";
            this.profilLoadStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.profilLoadStripMenu.Size = new System.Drawing.Size(154, 22);
            this.profilLoadStripMenu.Text = "P&rofile";
            this.profilLoadStripMenu.Click += new System.EventHandler(this.profilLoadStripMenu_Click);
            // 
            // saveStripMenu
            // 
            this.saveStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.physicsSaveStripMenu,
            this.profilSaveStripMenu});
            this.saveStripMenu.Image = global::Rocket_Mission.Properties.Resources.save;
            this.saveStripMenu.Name = "saveStripMenu";
            this.saveStripMenu.Size = new System.Drawing.Size(181, 22);
            this.saveStripMenu.Text = "&Save";
            // 
            // physicsSaveStripMenu
            // 
            this.physicsSaveStripMenu.Image = global::Rocket_Mission.Properties.Resources.physics;
            this.physicsSaveStripMenu.Name = "physicsSaveStripMenu";
            this.physicsSaveStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.P)));
            this.physicsSaveStripMenu.Size = new System.Drawing.Size(177, 22);
            this.physicsSaveStripMenu.Text = "&Physics";
            this.physicsSaveStripMenu.Click += new System.EventHandler(this.physicsSaveStripMenu_Click);
            // 
            // profilSaveStripMenu
            // 
            this.profilSaveStripMenu.Image = global::Rocket_Mission.Properties.Resources.userS;
            this.profilSaveStripMenu.Name = "profilSaveStripMenu";
            this.profilSaveStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.R)));
            this.profilSaveStripMenu.Size = new System.Drawing.Size(177, 22);
            this.profilSaveStripMenu.Text = "P&rofile";
            this.profilSaveStripMenu.Click += new System.EventHandler(this.profilSaveStripMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameModeStripMenu,
            this.toolStripSeparator4,
            this.physicsStripMenu,
            this.profilEditStripMenu});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.dToolStripMenuItem.Text = "&Options";
            // 
            // gameModeStripMenu
            // 
            this.gameModeStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalStripMenu,
            this.randomStripMenu});
            this.gameModeStripMenu.Name = "gameModeStripMenu";
            this.gameModeStripMenu.Size = new System.Drawing.Size(195, 22);
            this.gameModeStripMenu.Text = "&Landing Mode";
            // 
            // normalStripMenu
            // 
            this.normalStripMenu.Checked = true;
            this.normalStripMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalStripMenu.Name = "normalStripMenu";
            this.normalStripMenu.Size = new System.Drawing.Size(119, 22);
            this.normalStripMenu.Text = "&Normal";
            this.normalStripMenu.Click += new System.EventHandler(this.normalStripMenu_Click);
            // 
            // randomStripMenu
            // 
            this.randomStripMenu.Name = "randomStripMenu";
            this.randomStripMenu.Size = new System.Drawing.Size(119, 22);
            this.randomStripMenu.Text = "&Random";
            this.randomStripMenu.Click += new System.EventHandler(this.randomStripMenu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(192, 6);
            // 
            // physicsStripMenu
            // 
            this.physicsStripMenu.Image = global::Rocket_Mission.Properties.Resources.physics;
            this.physicsStripMenu.Name = "physicsStripMenu";
            this.physicsStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.P)));
            this.physicsStripMenu.Size = new System.Drawing.Size(195, 22);
            this.physicsStripMenu.Text = "&Physics...";
            this.physicsStripMenu.Click += new System.EventHandler(this.physicsStripMenu_Click);
            // 
            // profilEditStripMenu
            // 
            this.profilEditStripMenu.Image = global::Rocket_Mission.Properties.Resources.user;
            this.profilEditStripMenu.Name = "profilEditStripMenu";
            this.profilEditStripMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.R)));
            this.profilEditStripMenu.Size = new System.Drawing.Size(195, 22);
            this.profilEditStripMenu.Text = "P&rofile...";
            this.profilEditStripMenu.Click += new System.EventHandler(this.profilEditStripMenu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutStripMenu});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutStripMenu
            // 
            this.aboutStripMenu.Name = "aboutStripMenu";
            this.aboutStripMenu.Size = new System.Drawing.Size(116, 22);
            this.aboutStripMenu.Text = "&About...";
            this.aboutStripMenu.Click += new System.EventHandler(this.aboutStripMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rocketPics
            // 
            this.rocketPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rocketPics.ImageStream")));
            this.rocketPics.TransparentColor = System.Drawing.Color.Transparent;
            this.rocketPics.Images.SetKeyName(0, "rocket0.jpg");
            this.rocketPics.Images.SetKeyName(1, "rocket1.jpg");
            this.rocketPics.Images.SetKeyName(2, "rocket2.jpg");
            this.rocketPics.Images.SetKeyName(3, "rocket3.jpg");
            // 
            // lblGravity
            // 
            this.lblGravity.AutoSize = true;
            this.lblGravity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGravity.Location = new System.Drawing.Point(12, 80);
            this.lblGravity.Name = "lblGravity";
            this.lblGravity.Size = new System.Drawing.Size(54, 15);
            this.lblGravity.TabIndex = 8;
            this.lblGravity.Text = "Gravity:";
            this.lblGravity.Visible = false;
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWind.Location = new System.Drawing.Point(12, 102);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(89, 13);
            this.lblWind.TabIndex = 9;
            this.lblWind.Text = "Wind Velocity:";
            this.lblWind.Visible = false;
            // 
            // platformPic
            // 
            this.platformPic.Image = global::Rocket_Mission.Properties.Resources.platform;
            this.platformPic.Location = new System.Drawing.Point(280, 449);
            this.platformPic.Name = "platformPic";
            this.platformPic.Size = new System.Drawing.Size(570, 20);
            this.platformPic.TabIndex = 7;
            this.platformPic.TabStop = false;
            this.platformPic.Visible = false;
            // 
            // rocketPic
            // 
            this.rocketPic.Location = new System.Drawing.Point(544, 122);
            this.rocketPic.Name = "rocketPic";
            this.rocketPic.Size = new System.Drawing.Size(83, 97);
            this.rocketPic.TabIndex = 6;
            this.rocketPic.TabStop = false;
            this.rocketPic.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abortToolStripMenuItem1,
            this.abortSeparator,
            this.landingModeToolStripMenuItem,
            this.toolStripSeparator5,
            this.physicsToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(152, 104);
            // 
            // abortToolStripMenuItem1
            // 
            this.abortToolStripMenuItem1.Name = "abortToolStripMenuItem1";
            this.abortToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.abortToolStripMenuItem1.Text = "Abort";
            this.abortToolStripMenuItem1.Visible = false;
            this.abortToolStripMenuItem1.Click += new System.EventHandler(this.abortStripMenu_Click);
            // 
            // abortSeparator
            // 
            this.abortSeparator.Name = "abortSeparator";
            this.abortSeparator.Size = new System.Drawing.Size(148, 6);
            this.abortSeparator.Visible = false;
            // 
            // landingModeToolStripMenuItem
            // 
            this.landingModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalContextMenu,
            this.randomContextMenu});
            this.landingModeToolStripMenuItem.Name = "landingModeToolStripMenuItem";
            this.landingModeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.landingModeToolStripMenuItem.Text = "Landing Mode";
            // 
            // normalContextMenu
            // 
            this.normalContextMenu.Checked = true;
            this.normalContextMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.normalContextMenu.Name = "normalContextMenu";
            this.normalContextMenu.Size = new System.Drawing.Size(119, 22);
            this.normalContextMenu.Text = "Normal";
            this.normalContextMenu.Click += new System.EventHandler(this.normalStripMenu_Click);
            // 
            // randomContextMenu
            // 
            this.randomContextMenu.Name = "randomContextMenu";
            this.randomContextMenu.Size = new System.Drawing.Size(119, 22);
            this.randomContextMenu.Text = "Random";
            this.randomContextMenu.Click += new System.EventHandler(this.randomStripMenu_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(148, 6);
            // 
            // physicsToolStripMenuItem
            // 
            this.physicsToolStripMenuItem.Image = global::Rocket_Mission.Properties.Resources.physics;
            this.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            this.physicsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.physicsToolStripMenuItem.Text = "Physics";
            this.physicsToolStripMenuItem.Click += new System.EventHandler(this.physicsStripMenu_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Image = global::Rocket_Mission.Properties.Resources.user;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profilEditStripMenu_Click);
            // 
            // verticalPictureBox
            // 
            this.verticalPictureBox.Location = new System.Drawing.Point(195, 36);
            this.verticalPictureBox.Name = "verticalPictureBox";
            this.verticalPictureBox.Size = new System.Drawing.Size(18, 28);
            this.verticalPictureBox.TabIndex = 10;
            this.verticalPictureBox.TabStop = false;
            // 
            // arrowPics
            // 
            this.arrowPics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("arrowPics.ImageStream")));
            this.arrowPics.TransparentColor = System.Drawing.Color.Transparent;
            this.arrowPics.Images.SetKeyName(0, "arrowDown.GIF");
            this.arrowPics.Images.SetKeyName(1, "arrowUp.GIF");
            this.arrowPics.Images.SetKeyName(2, "arrowLeft.GIF");
            this.arrowPics.Images.SetKeyName(3, "arrowRight.GIF");
            // 
            // horizontalPictureBox
            // 
            this.horizontalPictureBox.Location = new System.Drawing.Point(214, 59);
            this.horizontalPictureBox.Name = "horizontalPictureBox";
            this.horizontalPictureBox.Size = new System.Drawing.Size(28, 18);
            this.horizontalPictureBox.TabIndex = 11;
            this.horizontalPictureBox.TabStop = false;
            // 
            // windPictureBox
            // 
            this.windPictureBox.Location = new System.Drawing.Point(164, 102);
            this.windPictureBox.Name = "windPictureBox";
            this.windPictureBox.Size = new System.Drawing.Size(28, 18);
            this.windPictureBox.TabIndex = 12;
            this.windPictureBox.TabStop = false;
            // 
            // rocketNotifyIcon
            // 
            this.rocketNotifyIcon.ContextMenuStrip = this.trayContextMenu;
            this.rocketNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("rocketNotifyIcon.Icon")));
            this.rocketNotifyIcon.Text = "Rocket Mission";
            this.rocketNotifyIcon.DoubleClick += new System.EventHandler(this.rocketNotifyIcon_DoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.ShowImageMargin = false;
            this.trayContextMenu.Size = new System.Drawing.Size(79, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.rocketNotifyIcon_DoubleClick);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 617);
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.windPictureBox);
            this.Controls.Add(this.horizontalPictureBox);
            this.Controls.Add(this.verticalPictureBox);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblGravity);
            this.Controls.Add(this.platformPic);
            this.Controls.Add(this.rocketPic);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblRockets);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblYVel);
            this.Controls.Add(this.lblXVel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rocket Mission";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platformPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocketPic)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verticalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windPictureBox)).EndInit();
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXVel;
        private System.Windows.Forms.Label lblYVel;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblRockets;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList rocketPics;
        private System.Windows.Forms.PictureBox rocketPic;
        private System.Windows.Forms.PictureBox platformPic;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutStripMenu;
        private System.Windows.Forms.ToolStripMenuItem gameModeStripMenu;
        private System.Windows.Forms.ToolStripMenuItem normalStripMenu;
        private System.Windows.Forms.ToolStripMenuItem randomStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem physicsStripMenu;
        private System.Windows.Forms.ToolStripMenuItem loadStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveStripMenu;
        private System.Windows.Forms.ToolStripMenuItem profilLoadStripMenu;
        private System.Windows.Forms.ToolStripMenuItem physicsLoadStripMenu;
        private System.Windows.Forms.ToolStripMenuItem profilSaveStripMenu;
        private System.Windows.Forms.ToolStripMenuItem physicsSaveStripMenu;
        private System.Windows.Forms.Label lblGravity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem profilEditStripMenu;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.ToolStripMenuItem testLaunchStripMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem physicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem normalContextMenu;
        private System.Windows.Forms.ToolStripMenuItem randomContextMenu;
        private System.Windows.Forms.PictureBox verticalPictureBox;
        private System.Windows.Forms.ImageList arrowPics;
        private System.Windows.Forms.PictureBox horizontalPictureBox;
        private System.Windows.Forms.PictureBox windPictureBox;
        private System.Windows.Forms.ToolStripMenuItem abortStripMenu;
        private System.Windows.Forms.ToolStripMenuItem abortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator abortSeparator;
        private System.Windows.Forms.NotifyIcon rocketNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

