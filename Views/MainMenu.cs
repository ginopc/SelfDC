using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using SelfDC.Utils;
using System.IO;
using System.Drawing;

namespace SelfDC.Views
{
    public partial class MainMenu : Form
    {
        private OrderForm oForm;
        private LabelsForm lForm;
        private InventoryForm iForm;

        public MainMenu()
        {
            ScsUtils.WriteLog("Creazione maschera " + this.Name);
            InitializeComponent();
            oForm = new OrderForm();
            lForm = new LabelsForm();
            iForm = new InventoryForm();
        }

        /** visualizza le info sul programma */
        private void actAbout(object sender, EventArgs e)
        {
            string ProductName = Assembly.GetExecutingAssembly().FullName;

            ScsUtils.WriteLog("Apertura info applicazione");
            MessageBox.Show(
                ProductName + "\nDesigned by Maurizio Aru"
                , "Info"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Asterisk
                ,MessageBoxDefaultButton.Button1);
        }

        private void actQuit(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("Richiesta di chiusura dell'applicazione da " + this.GetType().ToString());
            Close();
        }

        private void MainMenu_Closing(object sender, CancelEventArgs e)
        {
            DialogResult res = DialogResult.No;

            res = MessageBox.Show("Stai per chiudere l'applicazione?\nTutte le raccolte andranno perse\nContinuare?",
                "Chiusura Applicazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.No) e.Cancel = true;
            if (e.Cancel)
                ScsUtils.WriteLog("Chiusura annullata dall'utente");
            else
            {
                ScsUtils.WriteLog("Chiusura confermata dall'utente");
            }
        }

        private void actNewOrder(object sender, EventArgs e)
        {
            ScsUtils.WriteLog(string.Format("Richiesta apertura della maschera {0}", oForm.Name));
            oForm.Show();
        }

        private void actNewLabel(object sender, EventArgs e)
        {
            ScsUtils.WriteLog(string.Format("Richiesta apertura della maschera {0}", lForm.Name));
            lForm.Show();
        }

        private void actNewInventory(object sender, EventArgs e)
        {
            ScsUtils.WriteLog(string.Format("Richiesta apertura della maschera {0}", iForm.Name));
            iForm.Show();
        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            // definisco una matrice di pulsanti 3x3
            int numCols = 3;
            int numRows = 3;
            int borderSize = 3;

            // Ridimensiona i pulsanti in modo che stiano sempre in 3 colonne
            // calcola la dimensione minima
            int tableSize = this.ClientSize.Width > this.ClientSize.Height ? this.ClientSize.Height : this.ClientSize.Width;

            // calcolo la dimensione dei pulsanti in base alla grandezza della finestra
            // Pulsanti quadrati: H = W
            int btnWidth = tableSize / numCols;
            int btnHeight = btnWidth;
            
            /*
            for (int i = 0; i < numCols; i++) // colonne
            {
                for (int j = 0; j < numRows; j++) // righe
                {
                    // è uno dei pulsanti del menu
                    ctrl.Height = btnHeight - (2 * borderSize);
                    ctrl.Width = btnWidth - (2 * borderSize);
                }
            }
            */

            // colonna 1
            picButton11.Top = borderSize;
            picButton11.Left = borderSize;
            picButton11.Width = btnWidth - (2 * borderSize);
            picButton11.Height = btnHeight - (2 * borderSize);

            picButton12.Top = borderSize;
            picButton12.Left = btnWidth + borderSize;
            picButton12.Width = btnWidth - (2 * borderSize);
            picButton12.Height = btnHeight - (2 * borderSize);

            picButton13.Top = borderSize;
            picButton13.Left = (2 * btnWidth) + borderSize;
            picButton13.Width = btnWidth - (2 * borderSize);
            picButton13.Height = btnHeight - (2 * borderSize);

            // colonna 2
            picButton21.Top = borderSize;
            picButton21.Left = borderSize;
            picButton21.Width = btnWidth - (2 * borderSize);
            picButton21.Height = btnHeight - (2 * borderSize);

            picButton22.Top = borderSize;
            picButton22.Left = btnWidth + borderSize;
            picButton22.Width = btnWidth - (2 * borderSize);
            picButton22.Height = btnHeight - (2 * borderSize);

            picButton23.Top = borderSize;
            picButton23.Left = (2 * btnWidth) + borderSize;
            picButton23.Width = btnWidth - (2 * borderSize);
            picButton23.Height = btnHeight - (2 * borderSize);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("Caricamento maschera " + this.Name);

            string logoFileName = ScsUtils.GetAppPath() + Path.DirectorySeparatorChar + "app.png";
            if (File.Exists(logoFileName))
            {
                picLogo.Image = new Bitmap(logoFileName);
            }

            string appName = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            lblTitle.Text = string.Format("{0} v.{1}", appName, appVersion);
        }

        private void lblTitle_ParentChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Closed(object sender, EventArgs e)
        {
            // In chiusura salvo la configurazione
            Settings.SaveToFile(Settings.AppCfgFileName);
        }
    }
}