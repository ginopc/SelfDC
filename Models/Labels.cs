/**
 * Rappresent label data head, with customer reference
 * 
 * @author  Maurizio Aru
 * @date  : 25.04.2014
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SelfDC.Utils;

namespace SelfDC.Models
{
    public class Labels
    {
        /// <summary>
        /// Lista degli elementi dell'ordine
        /// </summary>
        private List<LabelItem> Items;

        public Labels()
        {
            this.Items = new List<LabelItem>();
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
        /// Add new item into order
        /// </summary>
        public void Add(LabelItem item)
        {
            Items.Add(item);
        }

        /// <summary>
        /// Remove item from order
        /// </summary>
        public void Remove(LabelItem item)
        {
            Items.Remove(item);
        }

        /// <summary>
        /// Update item into order
        /// </summary>
        public void Update(LabelItem item)
        {
            foreach (LabelItem currItem in this.Items)
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
        /// Export order to file
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

            foreach (LabelItem item in this.Items)
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
