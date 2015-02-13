using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidTouchMouseServer {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args) {
            if (args.Length > 0) {
                if (args[0].Equals("-start")) {
                    Log.WriteInfo("TouchMouseServer starting with flags: -start");
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new TouchMouseForm(true));
                }
            }
            else {
                Log.WriteInfo("TouchMouseServer starting");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TouchMouseForm(true));
            }
        }
    }
}
