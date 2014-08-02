using AndroidTouchMouseServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidTouchMouseServer {
    public partial class TouchMouseForm : Form {

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private BackgroundWorker bw;
        IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

        public TouchMouseForm() {
            InitializeComponent();
            InitSysTray();
            InitSysTrayProgram();
        }

        public TouchMouseForm(bool startServer) {
            InitializeComponent();
            InitSysTray();
            InitSysTrayProgram();
            if (startServer) {
                bw.RunWorkerAsync();
                trayMenu.MenuItems[0].Enabled = false;
            }
        }

        protected override void OnLoad(EventArgs e) {
            Visible = false;
            ShowInTaskbar = false;
            base.OnLoad(e);
        }

        private void OnStartServer(object sender, EventArgs e) {
            bw.RunWorkerAsync();
            trayMenu.MenuItems[0].Enabled = false;
        }

        private void OnAboutClicked(object sender, EventArgs e) {
            new AboutForm(host.AddressList).Show();
        }

        private void OnExit(object sender, EventArgs e) {
            Application.Exit();
        }

        private void InitSysTrayProgram() {
            bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(delegate(object o, DoWorkEventArgs args) {
                //BackgroundWorker worker = o as BackgroundWorker;
                new Listener();
            });
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(delegate(object o, RunWorkerCompletedEventArgs args) {
                //Console.WriteLine("Background worker finished");
            });
        }

        private void InitSysTray() {
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Start", OnStartServer);
            trayMenu.MenuItems.Add("About...", OnAboutClicked);
            trayMenu.MenuItems.Add("Exit", OnExit);
            trayIcon = new NotifyIcon();
            trayIcon.Text = "AndroidTouchMouse";
            trayIcon.Icon = new Icon("TouchMouseLogo.ico");
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
            IPAddress[] ips = Array.FindAll(host.AddressList, a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            String listenIPs = String.Join<IPAddress>(",", ips);
            trayIcon.Text = "AndroidTouchMouse - " + listenIPs;
        }
    }
}
