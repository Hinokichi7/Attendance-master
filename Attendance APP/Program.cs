using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_APP
{
    static class Program
    {
        public static string startTime = ConfigurationManager.AppSettings.Get("StartTime");
        public static string endTime = ConfigurationManager.AppSettings.Get("EndTime");
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignIn());
        }
    }
}
