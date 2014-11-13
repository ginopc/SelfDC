namespace SelfDC.Views
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mnuMain;

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
            System.Windows.Forms.PictureBox picButton11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.PictureBox picButton23;
            System.Windows.Forms.PictureBox picButton12;
            System.Windows.Forms.PictureBox picButton13;
            System.Windows.Forms.PictureBox picButton22;
            this.mnuMain = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuQuit = new System.Windows.Forms.MenuItem();
            this.mnuHelp = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            picButton11 = new System.Windows.Forms.PictureBox();
            picButton23 = new System.Windows.Forms.PictureBox();
            picButton12 = new System.Windows.Forms.PictureBox();
            picButton13 = new System.Windows.Forms.PictureBox();
            picButton22 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // picButton11
            // 
            picButton11.Image = ((System.Drawing.Image)(resources.GetObject("picButton11.Image")));
            picButton11.Location = new System.Drawing.Point(3, 34);
            picButton11.Name = "picButton11";
            picButton11.Size = new System.Drawing.Size(81, 75);
            picButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picButton11.Click += new System.EventHandler(this.actNewOrder);
            // 
            // picButton23
            // 
            picButton23.Image = ((System.Drawing.Image)(resources.GetObject("picButton23.Image")));
            picButton23.Location = new System.Drawing.Point(177, 115);
            picButton23.Name = "picButton23";
            picButton23.Size = new System.Drawing.Size(81, 75);
            picButton23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picButton23.Click += new System.EventHandler(this.actQuit);
            // 
            // picButton12
            // 
            picButton12.Image = ((System.Drawing.Image)(resources.GetObject("picButton12.Image")));
            picButton12.Location = new System.Drawing.Point(90, 34);
            picButton12.Name = "picButton12";
            picButton12.Size = new System.Drawing.Size(81, 75);
            picButton12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picButton12.Click += new System.EventHandler(this.actNewLabel);
            // 
            // picButton13
            // 
            picButton13.Enabled = false;
            picButton13.Image = ((System.Drawing.Image)(resources.GetObject("picButton13.Image")));
            picButton13.Location = new System.Drawing.Point(177, 34);
            picButton13.Name = "picButton13";
            picButton13.Size = new System.Drawing.Size(81, 75);
            picButton13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picButton13.Click += new System.EventHandler(this.actNewInventory);
            // 
            // picButton22
            // 
            picButton22.Image = ((System.Drawing.Image)(resources.GetObject("picButton22.Image")));
            picButton22.Location = new System.Drawing.Point(90, 115);
            picButton22.Name = "picButton22";
            picButton22.Size = new System.Drawing.Size(81, 75);
            picButton22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picButton22.Click += new System.EventHandler(this.actAbout);
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.Add(this.mnuFile);
            this.mnuMain.MenuItems.Add(this.mnuHelp);
            // 
            // mnuFile
            // 
            this.mnuFile.MenuItems.Add(this.mnuQuit);
            this.mnuFile.Text = "File";
            // 
            // mnuQuit
            // 
            this.mnuQuit.Text = "Esci";
            this.mnuQuit.Click += new System.EventHandler(this.actQuit);
            // 
            // mnuHelp
            // 
            this.mnuHelp.MenuItems.Add(this.mnuAbout);
            this.mnuHelp.Text = "?";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Text = "Info";
            this.mnuAbout.Click += new System.EventHandler(this.actAbout);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(picButton22);
            this.Controls.Add(picButton13);
            this.Controls.Add(picButton12);
            this.Controls.Add(picButton23);
            this.Controls.Add(picButton11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Menu = this.mnuMain;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainMenu_Closing);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuQuit;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuAbout;
    }
}