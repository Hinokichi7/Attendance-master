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
        public const string title_department = "部署";
        public const string title_employeeCode = "社員番号";
        public const string title_Name = "氏名";
        public const string title_Year = "年";
        public const string title_Month = "月";
        public const string title_Day = "日";
        public const string title_attendance = "出勤時間";
        public const string title_leavingWork = "退勤時間";
        public const string title_stampingName = "勤務種別";
        public const string title_workingHours = "勤務時間";
        public const string title_remark = "備考";
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
