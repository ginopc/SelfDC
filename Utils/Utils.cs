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
