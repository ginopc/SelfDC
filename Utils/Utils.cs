using System;
using System.Collections.Generic;
using System.IO;
using SelfDC.Models;

namespace SelfDC.Utils
{
    public static class ScsUtils
    {
        public static int EsportaOrdine(List<OrderItem> Items, string FileName)
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
                WriteLog("Si e' verificato un errore con messaggio: " + ex.Message);
                return -1;
            }

            // Esporta i dati
            string line;

            foreach (OrderItem item in Items)
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

        public static int EsportaEtichette(List<LabelItem> Items, string FileName)
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
                WriteLog("Si e' verificato un errore con messaggio: " + ex.Message);
                return -1;
            }

            // Esporta i dati
            string line;

            foreach (LabelItem item in Items)
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

        /// <summary>
        /// Write log message into log file
        /// </summary>
        /// <param name="logMsg"></param>
        public static void WriteLog(string logMsg)
        {
            StreamWriter sw = new StreamWriter(GetAppPath() + "\\" + GetAppAssemblyName() + "_log.txt", true);
            sw.WriteLine("{0:yyyy-MM-dd HH:mm:ss}: {1}", DateTime.Now, logMsg);
            sw.Close();
        }

        /// <summary>
        /// Return Application Path
        /// </summary>
        /// <returns>string of path</returns>
        public static string GetAppPath()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        }

        /// <summary>
        /// Return assembly filename without extension
        /// </summary>
        /// <returns></returns>
        public static string GetAppAssemblyName()
        {
            return Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        }
    }
}
