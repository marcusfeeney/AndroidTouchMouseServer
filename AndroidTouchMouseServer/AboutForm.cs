using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidTouchMouseServer {
    public partial class AboutForm : Form {

        IPAddress[] listenAddresses;

        public AboutForm(IPAddress[] listenAddresses) {
            InitializeComponent();
            this.listenAddresses = listenAddresses;
            SetFormText();
        }

        private void SetFormText() {
            foreach (IPAddress ip in listenAddresses) {
                serverAddressList.Items.Add(new ListViewItem(ip.ToString() + ":" + ConfigurationManager.AppSettings["port"]));
            }
        }

        private void licenseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://opensource.org/licenses/MIT");
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/marcusfeeney/AndroidTouchMouse");
        }
    }
}
