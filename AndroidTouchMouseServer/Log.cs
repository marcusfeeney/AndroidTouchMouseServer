using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidTouchMouseServer {
    static class Log {

        public static String LOG_FILE = "TouchMouseServer.log";

        public static void WriteInfo(String text) {
            using (StreamWriter file = new StreamWriter(LOG_FILE, true)) {
                file.WriteLine("INFO - " + DateTime.Now.ToString() + " - " + text);
            }
        }

        public static void WriteWarn(String text) {
            using (StreamWriter file = new StreamWriter(LOG_FILE, true)) {
                file.WriteLine("WARNING - " + DateTime.Now.ToString() + " - " + text);
            }
        }

        public static void WriteErr(String text) {
            using (StreamWriter file = new StreamWriter(LOG_FILE, true)) {
                file.WriteLine("ERROR - " + DateTime.Now.ToString() + " - " + text);
            }
        }

    }
}
