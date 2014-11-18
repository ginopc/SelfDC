namespace SelfDC.Views
{
    partial class MainMenu
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
            System.Windows.Forms.PictureBox btnInfo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.PictureBox btnQuit;
            this.picButton11 = new System.Windows.Forms.PictureBox();
            this.picButton12 = new System.Windows.Forms.PictureBox();
            this.picButton13 = new System.Windows.Forms.PictureBox();
            this.picButton21 = new System.Windows.Forms.PictureBox();
            this.picButton22 = new System.Windows.Forms.PictureBox();
            this.picButton23 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            btnInfo = new System.Windows.Forms.PictureBox();
            btnQuit = new System.Windows.Forms.PictureBox();
            this.pnlBody.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            btnInfo.Location = new System.Drawing.Point(3, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(40, 40);
            btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnInfo.Click += new System.EventHandler(this.actAbout);
            // 
            // btnQuit
            // 
            btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            btnQuit.Location = new System.Drawing.Point(3, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new System.Drawing.Size(40, 40);
            btnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnQuit.Click += new System.EventHandler(this.actQuit);
            // 
            // picButton11
            // 
            this.picButton11.Image = ((System.Drawing.Image)(resources.GetObject("picButton11.Image")));
            this.picButton11.Location = new System.Drawing.Point(3, 3);
            this.picButton11.Name = "picButton11";
            this.picButton11.Size = new System.Drawing.Size(81, 81);
            this.picButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton11.Click += new System.EventHandler(this.actNewOrder);
            // 
            // picButton12
            // 
            this.picButton12.Image = ((System.Drawing.Image)(resources.GetObject("picButton12.Image")));
            this.picButton12.Location = new System.Drawing.Point(90, 3);
            this.picButton12.Name = "picButton12";
            this.picButton12.Size = new System.Drawing.Size(81, 81);
            this.picButton12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton12.Click += new System.EventHandler(this.actNewLabel);
            // 
            // picButton13
            // 
            this.picButton13.Image = ((System.Drawing.Image)(resources.GetObject("picButton13.Image")));
            this.picButton13.Location = new System.Drawing.Point(177, 3);
            this.picButton13.Name = "picButton13";
            this.picButton13.Size = new System.Drawing.Size(81, 81);
            this.picButton13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton13.Click += new System.EventHandler(this.actNewInventory);
            // 
            // picButton21
            // 
            this.picButton21.Image = ((System.Drawing.Image)(resources.GetObject("picButton21.Image")));
            this.picButton21.Location = new System.Drawing.Point(3, 92);
            this.picButton21.Name = "picButton21";
            this.picButton21.Size = new System.Drawing.Size(81, 81);
            this.picButton21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton21.Visible = false;
            // 
            // picButton22
            // 
            this.picButton22.Image = ((System.Drawing.Image)(resources.GetObject("picButton22.Image")));
            this.picButton22.Location = new System.Drawing.Point(90, 92);
            this.picButton22.Name = "picButton22";
            this.picButton22.Size = new System.Drawing.Size(81, 81);
            this.picButton22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton22.Visible = false;
            // 
            // picButton23
            // 
            this.picButton23.Image = ((System.Drawing.Image)(resources.GetObject("picButton23.Image")));
            this.picButton23.Location = new System.Drawing.Point(177, 92);
            this.picButton23.Name = "picButton23";
            this.picButton23.Size = new System.Drawing.Size(81, 81);
            this.picButton23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButton23.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(43, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.picButton23);
            this.pnlBody.Controls.Add(this.picButton22);
            this.pnlBody.Controls.Add(this.picButton11);
            this.pnlBody.Controls.Add(this.picButton12);
            this.pnlBody.Controls.Add(this.picButton13);
            this.pnlBody.Controls.Add(this.picButton21);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 45);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(640, 390);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.panel3);
            this.pnlFooter.Controls.Add(btnInfo);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 435);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(640, 45);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(btnQuit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(592, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 45);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(640, 45);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(544, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 45);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTitle.Location = new System.Drawing.Point(0, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 17);
            this.lblTitle.Text = "Self DC v. 0.0.5";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainMenu_Closing);
            this.Resize += new System.EventHandler(this.MainMenu_Resize);
            this.pnlBody.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picButton11;
        private System.Windows.Forms.PictureBox picButton12;
        private System.Windows.Forms.PictureBox picButton13;
        private System.Windows.Forms.PictureBox picButton21;
        private System.Windows.Forms.PictureBox picButton22;
        private System.Windows.Forms.PictureBox picButton23;


    }
}