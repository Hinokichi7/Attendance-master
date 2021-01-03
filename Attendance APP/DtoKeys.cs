using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    class DtoKeys
    {
        public string Department { get; private set; }
        public string Employee { get; private set; }
        public string Stamping { get; private set; }
        public string StampingType { get; private set; }
        public string Table { get; private set; }

        public DtoKeys(string department, string employee, string stamping, string stampingType, string table)
        {
            this.Department = department;
            this.Employee = employee;
            this.Stamping = stamping;
            this.StampingType = stampingType;
            this.Table = table;
        }

        public override int GetHashCode()
        {
            return
                Department.GetHashCode() ^
                Employee.GetHashCode() ^
                Stamping.GetHashCode() ^
                StampingType.GetHashCode() ^
                Table.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                DtoKeys keys = (DtoKeys)obj;
                return (
                    this.Department == keys.Department &&
                    this.Employee == keys.Employee &&
                    this.Stamping == keys.Stamping &&
                    this.StampingType == keys.StampingType &&
                    this.Table == keys.Table
                    );
            }
        }
    }
}
