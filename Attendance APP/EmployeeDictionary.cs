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
                new EmployeeKeys(4,"渡辺 敏男", 4,"ddd", 1),
                new EmployeeKeys(5, "森田 利勝", 5, "eee", 0),
                new EmployeeKeys(6, "末永 好男", 1, "fff", 1),
                new EmployeeKeys(7, "尾上 千尋", 2, "ggg", 0),
                new EmployeeKeys(8, "大槻 龍宏", 3, "hhh", 0),
                new EmployeeKeys(9, "小俣 哲", 4, "iii", 0),
                new EmployeeKeys(10, "石倉 菜那", 5, "ggg", 0),

            };

            List<EmployeeDto> employees = new EmployeeDao().GetAllEmployee();


            this.EmployeeDic = new Dictionary<EmployeeKeys, EmployeeDto>();
            for(int i = 0; i < employeeKeys.Count; i++)
            {
                EmployeeDic[employeeKeys[i]] = employees[i];
            }
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
