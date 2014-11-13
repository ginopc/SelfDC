using System.IO;

namespace SelfDC.Utils
{
    public static class Settings
    {
        public static string AppCfgFileName = "";

        public static string CodiceCliente = "000000";              // default: 000000       Codice del cliente
        public static string OrdineFileName     = "ordine.txt";     // default: ordine.txt	 Nome del file ordine
        public static string InventarioFilename = "inventa.txt";    // default: inventa.txt	 Nome del file dati Inventario
        public static string EtichettaFilename  = "etichet.txt";    // default: etichet.txt	 Nome del file dati etichette
        public static string TipoTerminale      = "MT";             // default: MT           Tipo di terminale sul quale installo



        /// <summary>
        /// Loads settings from filesystem
        /// </summary>
        public static void LoadFromFile(string FileName)
        {
            if (File.Exists(FileName))
            {
                StreamReader sr = new StreamReader(FileName);
                CodiceCliente = sr.ReadLine();
                OrdineFileName = sr.ReadLine();
                InventarioFilename = sr.ReadLine();
                EtichettaFilename = sr.ReadLine();
                TipoTerminale = sr.ReadLine();
                sr.Close();
            }
        }

        /// <summary>
        /// Save settings to filesystem
        /// </summary>
        public static void SaveToFile(string FileName)
        {
            StreamWriter sw = new StreamWriter(FileName);
            sw.WriteLine(CodiceCliente);
            sw.WriteLine(OrdineFileName);
            sw.WriteLine(InventarioFilename);
            sw.WriteLine(EtichettaFilename);
            sw.WriteLine(TipoTerminale);
            sw.Close();
        }
    }
}
