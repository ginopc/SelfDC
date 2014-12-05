using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using SelfDC.Models;
using SelfDC.Utils;
using System.IO;

namespace SelfDC.Views
{
    public partial class LabelsForm : Form
    {
        bool ItemEdit = false;
        private List<LabelItem> listaProdotti;
        private IDevice bcReader;

        /** costruttore della classe */
        public LabelsForm()
        {
            InitializeComponent();
            txtCode.Text = "";
            txtQta.Text = "";
            listBox.Items.Clear();

            listaProdotti = new List<LabelItem>();

            // Crea l'oggetto del lettore scanner
            this.bcReader = ScsUtils.bcReader;
            
            ScsUtils.WriteLog("Creazione maschera " + this.Name);
        }

        private void LabelsForm_Load(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("Caricamento maschera " + this.Name);

            // Imposto la maschera a tutto schermo
            this.WindowState = FormWindowState.Maximized;
            statusBar.Text = "Nessun Record";
        }

        private void bcReader_OnScan(object sender, EventArgs e)
        {
            ScsUtils.WriteLog(string.Format("Evento {0}.OnScan chiamato da {1}", this.Name, sender.GetType().Name));
            String code = bcReader.Barcode;
            if (code == null) return;

            actNew(bcReader, null);

            if (code.StartsWith("$"))
            {
                // codice interno
                cbCodInterno.Checked = true;
                txtCode.Text = code.Substring(1, 7);
            }
            else
            {
                // codice ean
                cbCodInterno.Checked = false;
                txtCode.Text = code;
            }
            //txtQta.Text = "1";

            actSave(bcReader, null);
        }

        /** modifica l'elemento selezionato */
        private void actEdit(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndices[0];
            ListViewItem item = listBox.Items[index];

            ScsUtils.WriteLog(string.Format("In {0}, modifica della riga {1}", this.Name, index.ToString()));

            if (listBox.Items[index].Text == "")
            {
                cbCodInterno.Checked = true;
                txtCode.Text = listBox.Items[index].SubItems[1].Text;
            }
            else
            {
                cbCodInterno.Checked = false;
                txtCode.Text = listBox.Items[index].Text;
            }
            // blocco la checkbox
            cbCodInterno.Enabled = false;

            txtQta.Text = listBox.Items[index].SubItems[2].Text;
            txtQta.Focus();
            txtQta.Select(0, txtQta.Text.Length);
        }

        /** Inizia un nuovo inserimento manuale */
        private void actNew(object sender, EventArgs e)
        {
            ScsUtils.WriteLog(string.Format("In {0}, inserimento nuova riga", this.Name));

            txtCode.Text = "";
            txtCode.Enabled = true;
            txtQta.Text = "";
            txtQta.Enabled = true;
            cbCodInterno.Checked = true;
            cbCodInterno.Enabled = true;
            btnSave.Enabled = true;

            ItemEdit = false;
            txtCode.Focus();
        }

        /** Elimina l'elemento selezionato */
        private void actRemove(object sender, EventArgs e)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Non ci sono righe da eliminare", "Elimina Riga",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if (listBox.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleziona l'elemento da eliminare","Elimina Riga");
                return;
            }

            int index = listBox.SelectedIndices[0];
            ListViewItem item = listBox.Items[index];

            DialogResult res = MessageBox.Show(
                "Vuoi eliminare la riga selezionata?"
                , "Elimina Record"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button1);

            if (res == DialogResult.No) return;

            listBox.Items.Remove(listBox.Items[index]);
            statusBar.Text = listBox.Items.Count > 0 ? string.Format("{0} record", listBox.Items.Count) : "Nessun record";
            ScsUtils.WriteLog(string.Format("In {0}, cancellazione della riga {1}", this.Name, item.Text));
        }

        /*  Form Resize */
        private void LabelsForm_Resize(object sender, EventArgs e)
        {
            double ctlWidth = (double)ClientSize.Width;

            /** Resize listBox */
            listBox.Width = (int)ctlWidth;
            listBox.Columns[0].Width = (int)(ctlWidth * 0.50);
            listBox.Columns[1].Width = (int)(ctlWidth * 0.30);
            listBox.Columns[1].Width = (int)(ctlWidth * 0.20);

            ScsUtils.WriteLog("In " + this.Name + ", resize della finestra");
        }

        private void actQuit(object sender, EventArgs e)
        {
            bcReader.Close();
            this.Hide();
        }

        /** Esporta la lista in un file */
        private void actExport(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("In " + this.Name + ", esportazione dati su file");

            if (listBox.Items.Count == 0)
            {
                MessageBox.Show(
                    "Nessun dato da esportare"
                    ,"ATTENZIONE!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Asterisk
                    , MessageBoxDefaultButton.Button1);
                return;
            }

            DialogResult res = MessageBox.Show(
                        "Vuoi esportare il file?", 
                        "Esporta Etichette", 
                        MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question, 
                        MessageBoxDefaultButton.Button1);
            if (res == DialogResult.No) return;

            // Se il file esiste chiedo conferma di sovrascrittura
            if (File.Exists(Settings.EtichettaFilename))
            {
                res = MessageBox.Show(
                        "E' presente una precedente esportazione. Vuoi sovrascrivere?",
                        "Esporta Etichette",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1);
                if (res == DialogResult.No) return;
            }

            Labels labelList = new Labels();
            foreach (ListViewItem item in listBox.Items)
            {
                labelList.Add(new LabelItem(item.Text, item.SubItems[1].Text, Convert.ToInt32(item.SubItems[2].Text)));
            }
            if (labelList.ToFile(Settings.EtichettaFilename) < 0)
            {
                return;
            }

            /* removed by M. Aru
            listaProdotti.Clear();
            foreach (ListViewItem item in listBox.Items)
            {
                listaProdotti.Add(new LabelItem(item.Text, item.SubItems[1].Text, Convert.ToInt32(item.SubItems[2].Text)));
            }
            
            if (ScsUtils.EsportaEtichette(listaProdotti,Settings.EtichettaFilename) < 0)
            {
                return;
            }
             */ 

            listBox.Items.Clear();
            listBox_SelectedIndexChanged(sender, e);

            MessageBox.Show("File esportato con successo","Esporta Dati");
        }

        /** Abilita menu di modifica solo se è selezionata un riga della lista */
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // disabilito a prescindere i campi di input. Verranno riabilitati più avanti nella fuzione
            actFieldReset();

            if ((listBox.Items.Count == 0) || (listBox.SelectedIndices.Count == 0))
            {
                return;
            }

            int index = listBox.SelectedIndices[0];

            // Disable Edit menu if nothing is selected
            if (index >= 0)
            {
                // editing abilitato
                ItemEdit = true;
                mnuRemove.Enabled = true;
                cmnuRemove.Enabled = true;

                txtQta.Enabled = true;
                btnSave.Enabled = true;

                txtQta.SelectAll();
                actEdit(sender, e);
            }
            else {
                // editing disabilitato
                ItemEdit = false;
                mnuRemove.Enabled = false;
                cmnuRemove.Enabled = false;


                txtCode.Enabled = true;
                txtQta.Enabled = true;

                btnSave.Enabled = false;
            }
        }

        /** Salva modifica */
        private void actSave(object sender, EventArgs e)
        {
            bool ItemValid = false;

            if (txtCode.Text == "")
            {
                MessageBox.Show("Niente da inserire", "Salva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                actFieldReset();
                return;
            }

            // se ci sono elementi selezionati => è una modifica
            ListViewItem item;
            if ((listBox.SelectedIndices.Count > 0) && ItemEdit)
            {
                item = listBox.Items[listBox.SelectedIndices[0]];
                if (cbCodInterno.Checked)
                    item.SubItems[1].Text = txtCode.Text; // cod interno

                else
                    item.Text = txtCode.Text; // ean

                item.SubItems[2].Text = txtQta.Text; // qta
                ItemEdit = false;

                // nuovo inserimento con LabelItem
                LabelItem newItem = new LabelItem(item.Text, item.SubItems[1].Text, Convert.ToInt32(item.SubItems[2].Text));

                ScsUtils.WriteLog("In " + this.Name + ", salvataggio modifiche alla riga " + txtCode.Text);
            }
            else // Nuovo inserimento manuale
            {
                item = new ListViewItem();
                if (cbCodInterno.Checked) 
                {
                    item.Text = "";
                    item.SubItems.Add(txtCode.Text);
                }
                else
                {
                    item.Text = txtCode.Text;
                    item.SubItems.Add("");
                }

                if (txtQta.Text == "")
                {
                    txtQta.Text = "1";
                }
                item.SubItems.Add(txtQta.Text);

                // se la quantità non è valida annulla il salvataggio
                if (!Validate()) return;
                listBox.Items.Add(item);
                ScsUtils.WriteLog("In " + this.Name + ", nuovo inserimento della riga " + txtCode.Text);
            }

            this.statusBar.Text = string.Format("{0} record", listBox.Items.Count);

            // pulisco e disabilito i campi
            actFieldReset();
        }

        /** Reimposta ai controlli della maschera */
        private void actFieldReset()
        {
            txtCode.Text = "";
            txtCode.Enabled = false;
            txtQta.Text = "";
            txtQta.Enabled = false;
            cbCodInterno.Checked = true;
            cbCodInterno.Enabled = false;
            btnSave.Enabled = false;
        }

        /** Annulla modifica */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            actFieldReset();
        }

        /** visualizza le info sul programma */
        private void actAbout(object sender, EventArgs e)
        {
            string ProductName = Assembly.GetExecutingAssembly().FullName;
            MessageBox.Show(
                ProductName + "\ndesigned by Maurizio Aru"
                , "Info"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Asterisk
                ,MessageBoxDefaultButton.Button1);
        }

        /** Elimina tutte le righe dell'ordine */
        private void actRemoveAll(object sender, EventArgs e)
        {
            DialogResult res;

            ScsUtils.WriteLog("In " + this.Name + ", elimino tutti gli elementi");

            res = MessageBox.Show("Confermi l'eliminazine completa?", "Elimina Tutto"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.No)
                return;

            this.listBox.Items.Clear();
            statusBar.Text = "Nessun record";
        }

        private void txtQta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                // forzo la validazione del campo QTA
                listBox.Focus();

                // salvo i dati
                actSave(sender, e);
            }
                
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                actSave(sender, e);
        }

        private void cbCodInterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                actSave(sender, e);

        }

        /** richiesta chiusura */
        private void LabelsForm_Closing(object sender, CancelEventArgs e)
        {
            DialogResult res = MessageBox.Show(
                            "Vuoi uscire dall'applicazione?"
                            , "Uscita"
                            , MessageBoxButtons.YesNo
                            , MessageBoxIcon.Question
                            , MessageBoxDefaultButton.Button1);

            if (res == DialogResult.No) e.Cancel = true;
        }

        /** dopo conferma chiusura */
        private void LabelsForm_Closed(object sender, EventArgs e)
        {
            // Salvo le impostazioni
            Settings.SaveToFile(Settings.AppCfgFileName);

            // TODO: se esiste un ordine in fase di compilazione lo esporto su un file temporaneo

            // Prima di chiudere disabilito lo scanner
            if (System.Environment.OSVersion.Platform.ToString() == "WinCE")
                if (bcReader.Enabled) bcReader.Close();

        }


        private void LabelsForm_Activated(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("Maschera " + this.Name + " attivata");

            // serve per il debug sull'emulatore
            if (System.Environment.OSVersion.Platform.ToString() == "WinCE")
            {
                this.bcReader.OnScan += new EventHandler(this.bcReader_OnScan);
                bcReader.Open();
            }
        }

        private void LabelsForm_Deactivate(object sender, EventArgs e)
        {
            ScsUtils.WriteLog("Maschera " + this.Name + " disattivata");
            bcReader.Close();
            this.bcReader.OnScan -= new EventHandler(this.bcReader_OnScan);
        }

        private bool Validate()
        {
            double Num;

            // Se non c'è testo esco
            if (txtCode.Text.Trim().Length == 0)
            {
                MessageBox.Show("Inserire il codice");
                return false;
            }

            try
            {
                Num = double.Parse(txtQta.Text.Trim());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Errore nel campo Q.ta");
                return false;
            }
            if (Num > 0)
            {
                // formatto il numero
                txtQta.Text = string.Format("{0:#0}", Num);
            }

            return true;
        }
    }
}