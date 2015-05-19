namespace SelfDC.Views
{
    partial class OrderForm
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.cmnuDelete = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.mnuQuit = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuExport = new System.Windows.Forms.MenuItem();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuRemove = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.mnuRemoveAll = new System.Windows.Forms.MenuItem();
            this.panEdit = new System.Windows.Forms.Panel();
            this.cbCodInterno = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQta = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListView();
            this.clBarCode = new System.Windows.Forms.ColumnHeader();
            this.clProductCode = new System.Windows.Forms.ColumnHeader();
            this.clQta = new System.Windows.Forms.ColumnHeader();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panEdit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(138, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 20);
            label3.Text = "Colli";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(4, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.Text = "Codice:";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 295);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(314, 24);
            this.statusBar.Text = "statusBar";
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.Add(this.cmnuDelete);
            this.contextMenu.MenuItems.Add(this.menuItem4);
            this.contextMenu.MenuItems.Add(this.menuItem6);
            // 
            // cmnuDelete
            // 
            this.cmnuDelete.Text = "Elimina";
            this.cmnuDelete.Click += new System.EventHandler(this.actRemove);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "-";
            // 
            // menuItem6
            // 
            this.menuItem6.Text = "Elimina Tutti";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.mnuQuit);
            this.mainMenu.MenuItems.Add(this.menuItem1);
            this.mainMenu.MenuItems.Add(this.mnuEdit);
            // 
            // mnuQuit
            // 
            this.mnuQuit.Text = "<<";
            this.mnuQuit.Click += new System.EventHandler(this.actQuit);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.mnuExport);
            this.menuItem1.Text = "Ordine";
            // 
            // mnuExport
            // 
            this.mnuExport.Text = "Esporta";
            this.mnuExport.Click += new System.EventHandler(this.actExport);
            // 
            // mnuEdit
            // 
            this.mnuEdit.MenuItems.Add(this.mnuRemove);
            this.mnuEdit.MenuItems.Add(this.menuItem8);
            this.mnuEdit.MenuItems.Add(this.mnuRemoveAll);
            this.mnuEdit.Text = "Modifica";
            // 
            // mnuRemove
            // 
            this.mnuRemove.Text = "Elimina";
            this.mnuRemove.Click += new System.EventHandler(this.actRemove);
            // 
            // menuItem8
            // 
            this.menuItem8.Text = "-";
            // 
            // mnuRemoveAll
            // 
            this.mnuRemoveAll.Text = "Elimina Tutti";
            this.mnuRemoveAll.Click += new System.EventHandler(this.actRemoveAll);
            // 
            // panEdit
            // 
            this.panEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panEdit.Controls.Add(this.cbCodInterno);
            this.panEdit.Controls.Add(this.panel1);
            this.panEdit.Controls.Add(label3);
            this.panEdit.Controls.Add(label2);
            this.panEdit.Controls.Add(this.txtQta);
            this.panEdit.Controls.Add(this.txtCode);
            this.panEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panEdit.Location = new System.Drawing.Point(0, 0);
            this.panEdit.Name = "panEdit";
            this.panEdit.Size = new System.Drawing.Size(314, 86);
            // 
            // cbCodInterno
            // 
            this.cbCodInterno.Location = new System.Drawing.Point(202, 26);
            this.cbCodInterno.Name = "cbCodInterno";
            this.cbCodInterno.Size = new System.Drawing.Size(109, 20);
            this.cbCodInterno.TabIndex = 3;
            this.cbCodInterno.Text = "Cod. Interno";
            this.cbCodInterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbCodInterno_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 25);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.Location = new System.Drawing.Point(192, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(61, 25);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Nuovo";
            this.btnNew.Click += new System.EventHandler(this.actNew);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 25);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Reset Campi";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(253, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salva";
            this.btnSave.Click += new System.EventHandler(this.actSave);
            // 
            // txtQta
            // 
            this.txtQta.Location = new System.Drawing.Point(138, 26);
            this.txtQta.Name = "txtQta";
            this.txtQta.Size = new System.Drawing.Size(58, 23);
            this.txtQta.TabIndex = 1;
            this.txtQta.Text = "123.12";
            this.txtQta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQta_KeyPress);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(4, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(128, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "123456789012";
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // listBox
            // 
            this.listBox.Columns.Add(this.clBarCode);
            this.listBox.Columns.Add(this.clProductCode);
            this.listBox.Columns.Add(this.clQta);
            this.listBox.ContextMenu = this.contextMenu;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.FullRowSelect = true;
            this.listBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.Text = "123456789012";
            listViewItem1.SubItems.Add("");
            listViewItem1.SubItems.Add("10");
            listViewItem2.Text = "";
            listViewItem2.SubItems.Add("123456");
            listViewItem2.SubItems.Add("15");
            this.listBox.Items.Add(listViewItem1);
            this.listBox.Items.Add(listViewItem2);
            this.listBox.Location = new System.Drawing.Point(0, 86);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(314, 209);
            this.listBox.TabIndex = 5;
            this.listBox.TabStop = false;
            this.listBox.View = System.Windows.Forms.View.Details;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // clBarCode
            // 
            this.clBarCode.Text = "ean";
            this.clBarCode.Width = 167;
            // 
            // clProductCode
            // 
            this.clProductCode.Text = "codice";
            this.clProductCode.Width = 74;
            // 
            // clQta
            // 
            this.clQta.Text = "qta";
            this.clQta.Width = 57;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(314, 319);
            this.ContextMenu = this.contextMenu;
            this.ControlBox = false;
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panEdit);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Menu = this.mainMenu;
            this.Name = "OrderForm";
            this.Text = "Ordini";
            this.Deactivate += new System.EventHandler(this.OrderForm_Deactivate);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Closed += new System.EventHandler(this.OrderForm_Closed);
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.OrderForm_Closing);
            this.Resize += new System.EventHandler(this.OrderForm_Resize);
            this.panEdit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.MenuItem cmnuDelete;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mnuQuit;
        private System.Windows.Forms.MenuItem mnuEdit;
        private System.Windows.Forms.MenuItem mnuRemove;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem mnuRemoveAll;
        private System.Windows.Forms.MenuItem mnuExport;
        private System.Windows.Forms.Panel panEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQta;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ListView listBox;
        private System.Windows.Forms.ColumnHeader clBarCode;
        private System.Windows.Forms.ColumnHeader clQta;
        private System.Windows.Forms.ColumnHeader clProductCode;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbCodInterno;
        public System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.MenuItem menuItem1;
    }
}