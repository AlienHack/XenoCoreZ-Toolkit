using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace XenoCoreZ_Toolkits
{
    class FileToolkit
    {
        public static string GetMd5(string path)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var buffer = md5.ComputeHash(File.ReadAllBytes(path));
                var sb = new StringBuilder();
                foreach (var t in buffer)
                {
                    sb.Append(t.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static bool CompareFileHash(string pathA, string pathB)
        {
            return (string.CompareOrdinal(GetMd5(pathA), GetMd5(pathB)) == 0);
        }

    }
}
