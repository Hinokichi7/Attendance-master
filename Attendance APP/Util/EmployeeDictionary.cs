using Attendance_APP.Dao;
using Attendance_APP.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    class EmployeeDictionary
    {
        public Dictionary<EmployeeKeys, EmployeeDto> EmployeeDic;

        public EmployeeDictionary()
        {
            List<EmployeeKeys> employeeKeys = new List<EmployeeKeys>()
            {
                new EmployeeKeys(1, "岡崎 誠", 1,"aaa", 1),
                new EmployeeKeys(2, "永瀬 昌利", 2, "bbb", 0),
                new EmployeeKeys(3,"池田 沙菜", 3, "ccc", 0),

            };

            List<EmployeeDto> employees = new EmployeeDao().GetAllEmployee();

            this.EmployeeDic = new Dictionary<EmployeeKeys, EmployeeDto>()
            {
                { employeeKeys[0], employees[0] },
                { employeeKeys[1], employees[1] },
                { employeeKeys[2], employees[2]},
            };
        }

        public void xxx()
        {
            foreach (KeyValuePair<EmployeeKeys, EmployeeDto> dic in EmployeeDic)
            {
                Console.WriteLine($"{dic.Key}:{dic.Value}");
            }
        }
    }
}
