namespace GC.Library.Checkers
{
    internal static class OperationalSystem
    {    
        internal static bool IsWindows10()
        {
            var reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

            string productName = (string)reg.GetValue("ProductName");

            return productName.StartsWith("Windows 10");
        }
    }
}
