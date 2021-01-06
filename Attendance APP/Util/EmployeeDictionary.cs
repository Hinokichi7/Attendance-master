using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    class EmployeeDictionary
    {
        public Dictionary<EmployeeKeys, string> EmployeeDic;

        public EmployeeDictionary()
        {
            List<EmployeeKeys> dtoKeys = new List<EmployeeKeys>()
            {
                new EmployeeKeys(1, "岡崎 誠", 1,"aaa", 1),
                new EmployeeKeys(2, "永瀬 昌利", 2, "bbb", 0),
                new EmployeeKeys(3,"池田 沙菜", 3, "ccc", 0),

            };

            this.EmployeeDic = new Dictionary<EmployeeKeys, string>();

            foreach(EmployeeKeys dtoKey in dtoKeys)
            {
                if (EmployeeDic.ContainsKey(dtoKey))
                {
                    continue;
                }

                EmployeeDic.Add(dtoKey, "");
            }
        }

        public void xxx()
        {
            foreach (EmployeeKeys key in EmployeeDic.Keys)
            {
                Console.WriteLine($"{key}:{EmployeeDic[key]}");
            }
        }
    }
}
