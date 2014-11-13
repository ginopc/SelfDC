using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SelfDC.Utils;

namespace SelfDC.Models
{
    public class Order
    {
        /// <summary>
        /// Lista degli elementi dell'ordine
        /// </summary>
        private List<OrderItem> Items;

        public Order()
        {
            this.Items = new List<OrderItem>();
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
        public void Add(OrderItem item)
        {
            Items.Add(item);
        }

        /// <summary>
        /// Remove item from order
        /// </summary>
        public void Remove(OrderItem item)
        {
            Items.Remove(item);
        }

        /// <summary>
        /// Update item into order
        /// </summary>
        public void Update(OrderItem item)
        {
            foreach (OrderItem currItem in this.Items)
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

            foreach (OrderItem item in this.Items)
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
