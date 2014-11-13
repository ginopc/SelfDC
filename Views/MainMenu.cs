using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using SelfDC.Utils;

namespace SelfDC.Views
{
    public partial class MainMenu : Form
    {
        private OrderForm oForm;
        private LabelsForm lForm;

        public MainMenu()
        {
            ScsUtils.WriteLog("Creazione maschera " + this.Name);
            InitializeComponent();
            oForm = new OrderForm();
            lForm = new LabelsForm();
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
            ScsUtils.WriteLog(string.Format("Richiesta apertura della maschera {0}", "InventoryForm"));
            //throw new NotImplementedException();
        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            // definisco una matrice di pulsanti 3x3
            int numCols = 3;
            int numRows = 3;
            int borderSize = 3;

            // Ridimensiona i pulsanti in modo che stiano sempre in 3 colonne

            // calcolo la dimensione dei pulsanti in base alla grandezza della finestra
            int btnWidth = this.ClientSize.Width / numCols;
            int btnHeight = this.ClientSize.Height / numRows;

            // pulsanti quadrati con la dimensione minima
            if (btnWidth < btnHeight)
                btnHeight = btnWidth;
            else
                btnWidth = btnHeight;


            /*
            for (int i = 0; i < numCols; i++) // colonne
            {
                for (int j = 0; j < numRows; j++) // righe
                {
                    if ( )
                    {
                        // è uno dei pulsanti del menu
                        ctrl.Height = btnHeight - (2 * borderSize);
                        ctrl.Width = btnWidth - (2 * borderSize);
                    }
                }
            }
             */ 

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("Caricamento maschera " + this.Name);
        }

    }
}