﻿using Attendance_APP.Dao;
using System;
using System.Data;
using System.Windows.Forms;

namespace Attendance_APP.Dto
{
    public class StampingDto
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int EmployeeCode { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public DateTime Attendance { get; set; }
        public DateTime LeavingWork { get; set; }
        public int StampingCode { get; set; }
        public double WorkingHours { get; set; }
        public string Remark { get; set; }
    }
}
