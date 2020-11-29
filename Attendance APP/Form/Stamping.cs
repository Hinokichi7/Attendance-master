using Attendance_APP.Dao;
using Attendance_APP.Dto;
using Attendance_APP.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_APP
{
    public partial class Stamping : Form
    {
        private EmployeeDto Employee { get; set; }
        private StampingDto LatestStamping { get; set; }

        public Stamping(EmployeeDto employee)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Employee = employee;
            // 社員名
            lb_employee.Text = this.Employee.Name;
            // タイマー設定
            timer1.Interval = 1000;
            timer1.Enabled = true;
            lb_currentTime.Text = this.GetCurrentTime();
            // 画面読み込み
            this.GetAttendanceOrLeaving();

        }

        // 現在時刻表示
        private string GetCurrentTime()
        {
            return $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}";
        }
        // タイマー表示
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lb_currentTime.Text = this.GetCurrentTime();
        }

        // 出勤/退勤
        private void GetAttendanceOrLeaving()
        {
            // DBより最新のデータ読み込み
            this.LatestStamping = new StampingDao().GetLatestStamping(this.Employee.Code);
            // 新規(最新データがnull)であれば出勤画面
            // 既存で退勤時間が押されてあったら(退勤打刻が初期値でない)出勤画面
            if (this.LatestStamping == null || LatestStamping.LeavingWork.CompareTo(new DateTime()) != 0)
            {
                this.SetAttendanceMenu();
            }
            else
            {
                this.SetLevingMenu();
            }
        }

        // 出勤レコード追加
        private void AddAttemdance()
        {
            var dto = new StampingDto();
            dto.EmployeeCode = this.Employee.Code;
            dto.CreateTime = DateTime.Now;
            dto.Year = DateTime.Now.Year;
            dto.Month = DateTime.Now.Month;
            dto.Day = DateTime.Now.Day;
            dto.Attendance = DateTime.Now;
            dto.StampingCode = cmbStampingType1.GetSelectedStampingType().StampingCode;
            new StampingDao().AddStamping(dto);
        }

        // 退勤レコード追加
        private void UpdateLeaving()
        {
            var dto = new StampingDto();
            dto.UpdateTime = DateTime.Now;
            dto.LeavingWork = DateTime.Now;
            // 出勤時間、退勤時間を取得(丸め無し)
            var startTime = new WorkingHours().GetStartTime(this.LatestStamping.Attendance);
            var endTime = new WorkingHours().GetEndTime(dto.LeavingWork);
            dto.WorkingHours = new WorkingHours().GetWorkingHours(startTime, endTime);

            dto.Id = this.LatestStamping.Id;
            new StampingDao().UpdateStamping(dto);
        }

        // 出勤打刻画面
        private void SetAttendanceMenu()
        {
            // 退勤ボタン不可
            btn_leaving.Enabled = false;
        }

        // 退勤打刻画面
        private void SetLevingMenu()
        {
            // cmb_stampingTypeに設定・表示
            cmbStampingType1.SetLatestStampingType(this.LatestStamping);
            // 出勤ボタン不可
            btn_attendance.Enabled = false;
        }

        // 出勤ボタン
        private void btn_attendance_Click(object sender, EventArgs e)
        {
            // 二度押不可
            btn_attendance.Enabled = false;
            // 打刻時間の表示
            lb_stampingTime.Text = GetCurrentTime();

            this.AddAttemdance();

        }

        // 退勤ボタン
        private void btn_leaving_Click(object sender, EventArgs e)
        {
            // 二度押不可
            btn_leaving.Enabled = false;
            // 打刻時間の表示
            lb_stampingTime.Text = GetCurrentTime();

            this.UpdateLeaving();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
