using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace XenoCoreZ_Toolkits
{
    class NetworkToolkit
    {
        //TODO LIST 
        /*    GET POST METHOD     */

        public static string GetUrlContent(string urlAddress)
        {
            using (var client = new WebClient())
            {
                return client.DownloadString(urlAddress);
            }
        }

        public static void DownloadFile(string urlAddress, string path)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(urlAddress, path);
            }
        }

        public static void DownloadFileAndExecute(string urlAddress)
        {
            var r = new Random();
            using (var client = new WebClient())
            {
                var fileName = r.Next(1000000, 9999999) + ".exe";
                client.DownloadFile(urlAddress, Path.GetTempPath() + "\\" + fileName);
                Process.Start(fileName);
            }
        }
    }
}
