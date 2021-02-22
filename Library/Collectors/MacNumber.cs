using System;
using System.Net.NetworkInformation;

namespace GC.Library.Collectors
{
    internal static class MacNumber
    {
        internal static string GetEnderecoMAC1()
        {
            try
            {
                NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                String enderecoMAC = string.Empty;
                foreach (NetworkInterface adapter in nics)
                {
                    if (enderecoMAC == String.Empty)
                    {
                        IPInterfaceProperties properties = adapter.GetIPProperties();
                        enderecoMAC = adapter.GetPhysicalAddress().ToString();
                    }
                }
                return enderecoMAC;
            }
            catch (Exception)
            {
                return "UserWithoutMAC";
            }
        }
    }
}
