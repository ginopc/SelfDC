using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SelfDC.Utils;

namespace SelfDC.Models
{
    public class Inventory
    {
        /// <summary>
        /// Lista degli elementi dell'ordine
        /// </summary>
        private List<InventoryItem> Items;

        public Inventory()
        {
            this.Items = new List<InventoryItem>();
        }

        public string Customer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// Add new item into Inventory
        /// </summary>
        public void Add(InventoryItem item)
        {
            Items.Add(item);
        }

        /// <summary>
        /// Remove item from Inventory
        /// </summary>
        public void Remove(InventoryItem item)
        {
            Items.Remove(item);
        }

        /// <summary>
        /// Update item into Inventory
        /// </summary>
        public void Update(InventoryItem item)
        {
            foreach (InventoryItem currItem in this.Items)
            {
                if (currItem.productCode == item.productCode)
                {
                    currItem.barcode = item.barcode;
                    currItem.qta = item.qta;
                    return;
                }
            }
        }

        /// <summary>
        /// Export Inventory to file
        /// </summary>
        public int ToFile(string FileName)
        {
            int result = -1;

            // Scrive il file
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(FileName);
            }
            catch (Exception ex)
            {
                ScsUtils.WriteLog("Si e' verificato un errore con messaggio: " + ex.Message);
                return -1;
            }

            // Esporta i dati
            string line;

            foreach (InventoryItem item in this.Items)
            {
                line = string.Format("{0};{1};{2};{3}"
                        , Settings.CodiceCliente
                        , item.productCode
                        , item.barcode
                        , item.qta);
                sw.WriteLine(line);
                result++;
            }
            sw.Close();

            return result;
        }
    }
}
