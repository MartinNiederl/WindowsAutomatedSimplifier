using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace WindowsAutomatedSimplifier
{
    internal class RegistryAPI
    {
        private static RegistryAPI _instance;

        public static RegistryAPI Instance => _instance ?? (_instance = new RegistryAPI());

        public void AddValue(string keyPath, string valueName, object value) => Registry.SetValue(keyPath, valueName, value);
        public void DeleteValue(string keyPath)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                key?.DeleteValue("MyApp");
        }
        public void ChangeValue(string keyPath, string valueName, object value) => Registry.SetValue(keyPath, valueName, value);
        public string GetValue(string keyPath, string valueName) => (string)Registry.GetValue(keyPath, valueName, null);

        public void AddKey(string keyPath, string newKey, string value)
        {
            RegistryKey key = StringToKey(keyPath);
            key = key.CreateSubKey(newKey);
            key?.SetValue("", value);
            key = key?.CreateSubKey("command");
            key?.SetValue("", @"C:\Users\Mani\Documents\Schule\Projektentwicklung\WindowsAutomatedSimplifier\WindowsAutomatedSimplifier\bin\Debug\WindowsAutomatedSimplifier.exe");
        }

        public void DeleteKey()
        {
            
        }

        public void DeleteKeyTree()
        {
            
        }

        private RegistryKey StringToKey(string path)
        {
            RegistryKey key = GetRegistryHive(path);
            string substring = path.Substring(path.IndexOf("\\", StringComparison.Ordinal) + 1);
            do {
                int length = substring.IndexOf("\\", StringComparison.Ordinal);
                if (length < 1 || key == null) break;
                key = key.OpenSubKey(length < 1 ? substring.Substring(0) : substring.Substring(0, length), true);
                substring = substring.Substring(length + 1);
            } while (true);
            return key;
        }
        public void CreateBackup(string exportPath, string registryPath)
        {
            string path = "\"" + exportPath + "\"";
            string key = "\"" + registryPath + "\"";

            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "regedit.exe";
                proc.StartInfo.UseShellExecute = false;

                proc = Process.Start("regedit.exe", "/e " + path + " " + key);
                proc?.WaitForExit();
            }
            catch (Exception) { proc?.Dispose(); }
        }

        private bool IsPathValid(string path)
        {
            
            //TODO implement check for registryPath
            return false;
        }

        private RegistryKey GetRegistryHive(string path)
        {
            switch (path.Split('\\')[0].ToUpper())
            {
                case "HKEY_LOCAL_MACHINE": return Registry.LocalMachine;
                case "HKEY_CLASSES_ROOT": return Registry.ClassesRoot;
                case "HKEY_CURRENT_CONFIG": return Registry.CurrentConfig;
                case "HKEY_CURRENT_USER": return Registry.CurrentUser;
                case "HKEY_PERFORMANCE_DATA": return Registry.PerformanceData;
                case "HKEY_USERS": return Registry.Users;
                case "HKEY_DYN_DATA": return Registry.DynData;
                default: return Registry.LocalMachine;
            }
        }
    }
}
