using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    class TableDto
    {
        public string Department { get; private set; }
        public string Employee { get; private set; }
        public string Year { get; private set; }
        public string Month { get; private set; }
        public string Day { get; private set; }
        public string Attendance { get; private set; }
        public string LeavingWork { get; private set; }
        public string StampingType { get; private set; }
        public string WorkingHours { get; private set; }
        public string Remark { get; private set; }

        public TableDto(string department, string employee, string year, string month, string day, string attendance, string leavingWork, string stampingType, string workingHours, string remark)
        {
            this.Department = department;
            this.Employee = employee;
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.Attendance = attendance;
            this.LeavingWork = leavingWork;
            this.StampingType = stampingType;
            this.WorkingHours = workingHours;
            this.Remark = remark;
        }

        public override int GetHashCode()
        {
            return 
                Department.GetHashCode() ^
                Employee.GetHashCode() ^
                Year.GetHashCode() ^
                Month.GetHashCode() ^
                Day.GetHashCode() ^
                Attendance.GetHashCode() ^
                LeavingWork.GetHashCode() ^
                StampingType.GetHashCode() ^
                WorkingHours.GetHashCode() ^
                Remark.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                TableDto table = (TableDto)obj;
                return (
                    this.Department == table.Department &&
                    this.Employee == table.Employee &&
                    this.Year == table.Year &&
                    this.Month == table.Month &&
                    this.Day == table.Day &&
                    this.Attendance == table.Attendance &&
                    this.LeavingWork == table.LeavingWork &&
                    this.StampingType == table.StampingType &&
                    this.WorkingHours == table.WorkingHours &&
                    this.Remark == table.Remark
                    );

            }
        }
    }
}
