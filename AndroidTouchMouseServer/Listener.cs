using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidTouchMouseServer {
    class Listener {

        private Int32 port = Convert.ToInt32(ConfigurationManager.AppSettings["port"]);
        private IPAddress localhost = IPAddress.Any;
        private byte[] bytes;
        private String data = null;

        private const int MOUSEEVENT_LEFTDOWN = 0x0002;
        private const int MOUSEEVENT_LEFTUP = 0x0004;
        private const int MOUSEEVENT_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENT_RIGHTUP = 0x0010;

        private int desktopWidth = SystemInformation.VirtualScreen.Width;
        private int desktopHeight = SystemInformation.VirtualScreen.Height;

        public Listener() {

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEP = new IPEndPoint(localhost, port);

            try {
                server.Bind(localEP);
                server.Listen(10);
                Log.WriteInfo("Listening on " + localhost.ToString() + ":" + port);
                Log.WriteInfo("Usable screen space: " + desktopWidth + "x" + desktopHeight);
                while (true) {
                    
                    Socket handler = server.Accept();
                    data = null;
                    while (true) {
                        bytes = new byte[256];
                        int bytesRecieved = handler.Receive(bytes);
                        data += System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRecieved);
                        if (data.IndexOf(";") > -1) {
                            break;
                        }
                    }

                    String[] fields = data.Split('|');

                    switch (fields[0]) {
                        case "0x00":
                            SetPointerPosition(fields[1], fields[2]);
                            break;

                        case "0x10":
                            SetPointerClick(fields[1], fields[2]);
                            break;

                        default:
                            break;
                    }
                    handler.Close();
                }
            }
            catch (SocketException e) {
                Console.WriteLine(e.Message);
                Log.WriteErr(e.Message);
            }
            finally {
                server.Close();
                Log.WriteInfo("Server stopped");
            }
        }

        private void SetPointerClick(String buttonRaw, String stateRaw) {
            if (buttonRaw.Equals("LEFT")) {
                mouse_event(MOUSEEVENT_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                mouse_event(MOUSEEVENT_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            }
            else if (buttonRaw.Equals("RIGHT")) {
                mouse_event(MOUSEEVENT_RIGHTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                mouse_event(MOUSEEVENT_RIGHTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
            }
        }

        private void SetPointerPosition(String xRaw, String yRaw) {
            int x = Convert.ToInt32(xRaw);
            int y = Convert.ToInt32(yRaw);
            Cursor.Position = new Point(Cursor.Position.X + x, Cursor.Position.Y + y);
            int clipx = (desktopWidth/2) * -1;
            Cursor.Clip = new Rectangle(new Point(clipx, 0), new Size(desktopWidth, desktopHeight));
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
    }
}
