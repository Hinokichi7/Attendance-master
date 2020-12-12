using Attendance_APP.Dto;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

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
                        DepartmentCode = int.Parse(dr["departmentCode"].ToString()),
                        Password = dr["password"].ToString(),
                        AdminFlug = int.Parse(dr["adminFlug"].ToString())
                    };
                    list.Add(dto);
                }
                return list;
            }
        }

        public List<EmployeeDto> GetDepartmentEmployee(List<int> departmentCodes)
        {
            var list = new List<EmployeeDto>();
            var dt = new DataTable();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * ");
            sql.Append("FROM Attendance.dbo.Employee ");
            sql.Append("WHERE ");
            string inValue = string.Join(",", departmentCodes);
            sql.Append("departmentCode IN(" + inValue + ")");

            using (var conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
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
                        DepartmentCode = int.Parse(dr["departmentCode"].ToString()),
                        Password = dr["password"].ToString(),
                        AdminFlug = int.Parse(dr["adminFlug"].ToString())
                    };
                    list.Add(dto);
                }
                return list;
            }
        }

        public List<EmployeeDto> GetSelectedEmployee(List<int> employeeCodes)
        {
            var list = new List<EmployeeDto>();
            var dt = new DataTable();

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * ");
            sql.Append("FROM Attendance.dbo.Employee ");
            sql.Append("WHERE ");
            string inValue = string.Join(",", employeeCodes);
            sql.Append("code IN(" + inValue + ")");

            using (var conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
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
                        DepartmentCode = int.Parse(dr["departmentCode"].ToString()),
                        Password = dr["password"].ToString(),
                        AdminFlug = int.Parse(dr["adminFlug"].ToString())
                    };
                    list.Add(dto);
                }
                return list;
            }
        }

    }
}
