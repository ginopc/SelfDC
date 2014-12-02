using System;
using System.Windows.Forms;
using SelfDC.Utils;
using System.Reflection;
using SelfDC.Views;

namespace SelfDC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            String appName = Assembly.GetExecutingAssembly().GetName().Name;
            String appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            /* Load app settings */
            ScsUtils.WriteLog(string.Format("=== {0} ver. {1} ===", appName, appVersion));
            ScsUtils.WriteLog("Caricamento impostazioni...");
            Settings.AppCfgFileName = string.Format("{0}\\conf.txt", ScsUtils.GetAppPath());
            Settings.LoadFromFile(Settings.AppCfgFileName);

            /* Crea l'oggetto per lo scanner barcode */
            ScsUtils.WriteLog("Inizializzazione scanner (Tipo Term: " + Settings.TipoTerminale);
            if (Settings.TipoTerminale == "DL")
                ScsUtils.bcReader = new Datalogic();
            else
                ScsUtils.bcReader = new Motorola();

            /* show main form */
            Application.Run(new SelfDC.Views.MainMenu());

            /* Save Config File */
            Settings.SaveToFile(Settings.AppCfgFileName);
            ScsUtils.WriteLog("Applicazione terminata correttamente");
        }
    }
}