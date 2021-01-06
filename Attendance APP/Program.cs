using System.Configuration;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Attendance_APP.Dto;

namespace Attendance_APP
{
    static class Program
    {
        // 勤務開始・終了時刻
        public static string startTime = ConfigurationManager.AppSettings.Get("StartTime");
        public static string endTime = ConfigurationManager.AppSettings.Get("EndTime");
        // サインインパターン
        public static Regex id_pattarn = new Regex("[0-9]{3}");
        public static Regex password_pattern = new Regex("[0-9a-zA-Z]{3,}");
        // 一覧表示ヘッダー
        public const string header_department = "部署";
        public const string header_employeeCode = "社員番号";
        public const string header_Name = "氏名";
        public const string header_Year = "年";
        public const string header_Month = "月";
        public const string header_Day = "日";
        public const string header_attendance = "出勤時間";
        public const string header_leavingWork = "退勤時間";
        public const string header_stampingName = "勤務種別";
        public const string header_workingHours = "勤務時間";
        public const string header_remark = "備考";
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
