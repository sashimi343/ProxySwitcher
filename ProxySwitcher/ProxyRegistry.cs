using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ProxySwitcher
{
    class ProxyRegistry
    {
        private const string REG_KEY_WININET = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings";
        private const string REG_NAME_PROXY_ENABLE = "ProxyEnable";
        private const string REG_NAME_PROXY_SERVER = "ProxyServer";

        private const int PROXY_ENABLE = 1;
        private const int PROXY_DISABLE = 0;

        public void Enable(string proxyServer)
        {
            Registry.SetValue(REG_KEY_WININET, REG_NAME_PROXY_ENABLE, PROXY_ENABLE);
            Registry.SetValue(REG_KEY_WININET, REG_NAME_PROXY_SERVER, proxyServer);
        }

        public void Disable()
        {
            Registry.SetValue(REG_KEY_WININET, REG_NAME_PROXY_ENABLE, PROXY_DISABLE);
        }

        public bool IsEnabled()
        {
            int proxyEnabled = (int)Registry.GetValue(REG_KEY_WININET, REG_NAME_PROXY_ENABLE, PROXY_DISABLE);
            return proxyEnabled == PROXY_ENABLE;
        }
    }
}
