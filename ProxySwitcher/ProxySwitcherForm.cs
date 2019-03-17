using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxySwitcher
{
    public partial class ProxySwitcherForm : Form
    {

        private const string LABEL_PROXY_IS_ON = "Proxy is Running...";
        private const string LABEL_PROXY_IS_OFF = "Proxy is Off";

        private ProxyRegistry proxyRegistry;

        public ProxySwitcherForm()
        {
            InitializeComponent();

            proxyRegistry = new ProxyRegistry();
            UpdateButtonStyle();
        }

        private void toggleProxyButton_Click(object sender, EventArgs e)
        {
            if (proxyRegistry.IsEnabled())
            {
                proxyRegistry.Disable();
            }
            else
            {
                string proxyServer = GetProxyServer();
                proxyRegistry.Enable(proxyServer);
            }

            UpdateButtonStyle();
        }

        private void UpdateButtonStyle()
        {
            if (proxyRegistry.IsEnabled())
            {
                toggleProxyButton.Text = LABEL_PROXY_IS_ON;
                toggleProxyButton.BackColor = Color.OrangeRed;
            }
            else
            {
                toggleProxyButton.Text = LABEL_PROXY_IS_OFF;
                toggleProxyButton.BackColor = Form.DefaultBackColor;
            }
        }

        private string GetProxyServer()
        {
            int portNumber = (int)proxyPortForm.Value;

            return string.Format("http://127.0.0.1:{0}", portNumber);
        }
    }
}
