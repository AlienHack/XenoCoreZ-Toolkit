using System;
using Microsoft.Win32;

namespace XenoCoreZ_Toolkits
{
    class RegistryToolkit
    {
        public static bool CheckRegistryLocalMachine(string baseReg, string keyToCompare, string valueToCompare)
        {
            try
            {
                using (var key = Registry.LocalMachine.OpenSubKey(baseReg))
                {
                    var o = key?.GetValue(keyToCompare);
                    if (o == null) return false;
                    var version = o.ToString();
                    if (string.CompareOrdinal(valueToCompare, version) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)  
            {
                return false;
            }
        }

        public static bool CheckRegistryCurrentUser(string baseReg, string keyToCompare, string valueToCompare)
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(baseReg))
                {
                    var o = key?.GetValue(keyToCompare);
                    if (o == null) return false;
                    var version = o.ToString();
                    if (string.CompareOrdinal(valueToCompare, version) == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)  
            {
                return false;
            }
        }

        public static void WriteRegistryLocalMachine(string baseReg, string baseKey, string value)
        {
            if (baseKey == null) throw new ArgumentNullException(nameof(baseKey));
            var key = Registry.LocalMachine.CreateSubKey(baseReg);

            key?.SetValue(baseKey, value);

        }

        public static void WriteRegistryCurrentUser(string baseReg, string baseKey, string value)
        {
            if (baseKey == null) throw new ArgumentNullException(nameof(baseKey));
            var key = Registry.CurrentUser.CreateSubKey(baseReg);

            key?.SetValue(baseKey, value);

        }

    }
}
