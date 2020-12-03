﻿using Attendance_APP.Dao;
using Attendance_APP.Dto;
using Attendance_APP.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_APP.Admin
{
    public partial class EditRecord : Form
    {
        private EmployeeDto employee;
        private StampingDto Stamping { get; set; }

        public EditRecord(EmployeeDto employee, List<StampingDto> stamping)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.employee = employee;
            this.Stamping = stamping[0];
            label1.Text = this.employee.Name;
            this.InitializeText();
        }

        private (int startHour, int startMinut, int endHour, int emdMinut) GetTime()
        {
            return (this.Stamping.Attendance.Hour, this.Stamping.Attendance.Minute, this.Stamping.LeavingWork.Hour, this.Stamping.LeavingWork.Minute);
        }

        private void InitializeText()
        {
            cmbDate1.GetSelectedValue2(this.Stamping);
            cmbStampingType1.GetSelectedValue2(this.Stamping);
            this.SetCmbBoxTime(cmb_startHour, 1, 24, GetTime().startHour);
            this.SetCmbBoxTime(cmb_startMinut, 0, 59, GetTime().startMinut);
            this.SetCmbBoxTime(cmb_endHour, 1, 24, GetTime().endHour);
            this.SetCmbBoxTime(cmb_endMinut, 0, 59, GetTime().emdMinut);
            remark.Text = this.Stamping.Remark;
        }

        private DateTime GetStampingTime(int hour, int minute)
        {
            var date = cmbDate1.GetSelectedValue();
            return DateTime.Parse(string.Format($"{date.year:d4}/{date.month:d2}/{date.day:d2} {hour:d2}:{minute:d2}:00"));
        }

        private void SetCmbBoxTime(ComboBox cmb, int n, int max, int ix)
        {
            for (var i = n; i <= max; i++)
            {
                cmb.Items.Add(i);
            }
            //cmb.SelectedIndex = ix;
            cmb.Text = ix.ToString();
            cmb.FormatString = "00";
        }


        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            var dto = new StampingDto();
            dto.Id = this.Stamping.Id;
            dto.EmployeeCode = this.employee.Code;
            dto.UpdateTime = DateTime.Now;
            dto.Year = cmbDate1.GetSelectedValue().year;
            dto.Month = cmbDate1.GetSelectedValue().month;
            dto.Day = cmbDate1.GetSelectedValue().day;

            var startHour = (int)cmb_startHour.SelectedItem;
            var startMinute = (int)cmb_startMinut.SelectedItem;
            var endHour = (int)cmb_endHour.SelectedItem;
            var endMinute = (int)cmb_endMinut.SelectedItem;
            dto.Attendance = this.GetStampingTime(startHour, startMinute);
            dto.LeavingWork = this.GetStampingTime(endHour, endMinute);
            dto.StampingCode = cmbStampingType1.GetSelectedStampingType().StampingCode;
            // 出勤時間、退勤時間を取得(丸め無し)
            var startTime = new WorkingHours().GetStartTime(this.GetStampingTime(startHour, startMinute));
            var endTime = new WorkingHours().GetEndTime(this.GetStampingTime(endHour, endMinute));
            // 労働時間
            dto.WorkingHours = new WorkingHours().GetWorkingHours(startTime, endTime);
            dto.Remark = remark.Text;

            DialogResult result = MessageBox.Show(dto.Attendance.ToString("yyyy/MM/dd") + "のレコードをを更新します、よろしいですか？", "", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                new StampingDao().UpdateEditRecord(dto);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
