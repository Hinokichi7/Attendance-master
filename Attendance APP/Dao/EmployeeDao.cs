﻿using Attendance_APP.Dto;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Attendance_APP.Dao
{
    class EmployeeDao : Dao
    {
        public List<EmployeeDto> GetAllEmployee()
        {
            var list = new List<EmployeeDto>();
            var dt = new DataTable();
            using (var conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance.dbo.Employee", conn))
            {
                conn.Open();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    var dto = new EmployeeDto
                    {
                        Code = int.Parse(dr["code"].ToString()),
                        Name = dr["name"].ToString(),
                        DepartmentCode = int.Parse(dr["departmentCode"].ToString())
                    };
                    list.Add(dto);
                }
                return list;
            }
        }

    }
}
