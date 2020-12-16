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

        public EmployeeDto GetSelectedEmployee(int employeeCode)
        {
            var dt = new DataTable();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * ");
            sql.Append("FROM Attendance.dbo.Employee ");
            sql.Append("WHERE ");
            sql.Append("code = " + employeeCode );

            using (var conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
            {
                conn.Open();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                var dto = new EmployeeDto();
                dto.Code = int.Parse("code".ToString());
                dto.Name = "name".ToString();
                dto.DepartmentCode = int.Parse("departmentCode".ToString());
                dto.Password = "password".ToString();
                dto.AdminFlug = int.Parse("adminFlug".ToString());
                return dto;
            }
        }

        public List<EmployeeDto> GetSelectedEmployees(List<int> employeeCodes)
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
