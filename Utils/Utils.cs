/**
 * Utils class
 * 
 * @author  Maurizio Aru
 * @date  : 25.04.2014
 * 
 */
using System;
using System.Collections.Generic;
using System.IO;
using SelfDC.Models;

namespace SelfDC.Utils
{
    public static class ScsUtils
    {
        public static IDevice bcReader;
        /// <summary>
        /// Write log message into log file
        /// </summary>
        /// <param name="logMsg"></param>
        public static void WriteLog(string logMsg)
        {
            string LogPath = string.Format("{0}\\LOG", GetAppPath());
            string LogFileName = string.Format("{0}\\{1}_log-{2:yyyyMMdd}.txt", LogPath, GetAppAssemblyName(), DateTime.Now);

            if (!Directory.Exists(LogPath))
                Directory.CreateDirectory(LogPath);
            StreamWriter sw = new StreamWriter(LogFileName, true);
            sw.WriteLine("{0:HH:mm:ss}: {1}", DateTime.Now, logMsg);
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
