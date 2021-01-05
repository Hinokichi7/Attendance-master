using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    class Dtos
    {
        public Dictionary<DtoKeys, string> DtoDic;

        public Dtos()
        {
            List<DtoKeys> dtoKeys = new List<DtoKeys>()
            {
                new DtoKeys(1, "StampingDto"),
                new DtoKeys(2, "EmployeeDto"),
                new DtoKeys(3, "DepartmentDto"),
                new DtoKeys(4, "StampingTypeDto"),
                new DtoKeys(5, "TableDto"),
            };

            this.DtoDic = new Dictionary<DtoKeys, string>();

            foreach(DtoKeys dtoKey in dtoKeys)
            {
                if (DtoDic.ContainsKey(dtoKey))
                {
                    continue;
                }

                DtoDic.Add(dtoKey, "");
            }
        }

        public void xxx()
        {
            foreach (DtoKeys key in DtoDic.Keys)
            {
                Console.WriteLine($"{key}:{DtoDic[key]}");
            }
        }
    }
}
