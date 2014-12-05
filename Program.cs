using System;
using System.Windows.Forms;
using SelfDC.Utils;
using System.Reflection;
using SelfDC.Views;
using System.Threading;
using System.Diagnostics;

namespace SelfDC
{
    static class Program
    {
        static string appName = Assembly.GetExecutingAssembly().GetName().Name;
        static string appVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        static string appGuid = "abf2a777-ace8-40f3-a0ff-0aac712264c5";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {

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