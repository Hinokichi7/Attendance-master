using Attendance_APP.Contorol;
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
    public partial class NewRecord : Form
    {
        public NewRecord()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.InitializeCmbBox();
        }

        private void InitializeCmbBox()
        {
            this.SetCmbBoxTime(cmb_startHour, 1, 24, 8);
            this.SetCmbBoxTime(cmb_startMinut, 0, 59, 0);
            this.SetCmbBoxTime(cmb_endHour, 1, 24, 17);
            this.SetCmbBoxTime(cmb_endMinut, 0, 59, 0);
        }

        private DateTime GetStampingTime(ComboBox cmbHour, ComboBox cmbmMinut)
        {
            return DateTime.Parse(string.Format($"{cmbDate1.GetSelectedValue().year:d4}/{cmbDate1.GetSelectedValue().month:d2}/{cmbDate1.GetSelectedValue().day:d2} {cmbHour.SelectedItem:d2}:{cmbmMinut.SelectedItem:d2}:00"));
        }

        private void SetCmbBoxTime(ComboBox cmb, int n, int max, int ix)
        {
            for (var i = n; i <= max; i++)
            {
                cmb.Items.Add(i);
            }
            cmb.SelectedIndex = ix;
            cmb.FormatString = "00";
        }

        private void AddNewRecord_Click_1(object sender, EventArgs e)
        {
            var dto = new StampingDto();
            dto.EmployeeCode = cmbEmployee2.SelectedEmployees[0].Code;
            dto.CreateTime = DateTime.Now;
            dto.Year = cmbDate1.GetSelectedValue().year;
            dto.Month = cmbDate1.GetSelectedValue().month;
            dto.Day = cmbDate1.GetSelectedValue().day;
            dto.Attendance = this.GetStampingTime(cmb_startHour, cmb_startMinut);
            dto.LeavingWork = this.GetStampingTime(cmb_endHour, cmb_endMinut);
            dto.StampingCode = cmbStampingType1.GetSelectedStampingType().StampingCode;
            // 出勤時間、退勤時間を取得(丸め無し)
            var startTime = new WorkingHours().GetStartTime(this.GetStampingTime(cmb_startHour, cmb_startMinut));
            var endTime = new WorkingHours().GetEndTime(this.GetStampingTime(cmb_endHour, cmb_endMinut));
            // 労働時間
            dto.WorkingHours = new WorkingHours().GetWorkingHours(startTime, endTime);
            dto.Remark = remark.Text;
            new StampingDao().AddNewRecord(dto);
            this.Close();
        }
    }
}
