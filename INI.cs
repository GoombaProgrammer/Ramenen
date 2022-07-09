using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ramenen_For_Work {
    static internal class INI {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

        public static string ReadIni(string path, string section, string key) {
            StringBuilder sb = new();
            GetPrivateProfileString(section, key, "", sb, 500, path);
            return sb.ToString();
        }

        public static void WriteIni(string path, string section, string key, string value) {
            WritePrivateProfileString(section, key, value, path);
        }
    }
}
