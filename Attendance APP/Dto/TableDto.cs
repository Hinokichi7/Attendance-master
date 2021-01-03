using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    class TableDto
    {
        public string Department { get; set; }
        public string Employee { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Attendance { get; set; }
        public string LeavingWork { get; set; }
        public string StampingType { get; set; }
        public string WorkingHours { get; set; }
        public string Remark { get; set; }
    }
}
