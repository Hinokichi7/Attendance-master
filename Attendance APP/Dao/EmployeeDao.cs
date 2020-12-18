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
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance.dbo.Employee", conn))
            {
                conn.Open();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return this.SetEmployeeDto(dt);
            }
        }

        // DataTableをEmployeeDtoに変換
        private List<EmployeeDto> SetEmployeeDto(DataTable dt)
        {
            var list = new List<EmployeeDto>();
            foreach(DataRow dr in dt.Rows)
            {
                EmployeeDto dto = new EmployeeDto
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

        // 複数検索用
        public List<EmployeeDto> GetEmployees(List<int> codes, StringBuilder sql)
        {
            var dt = new DataTable();
            using (var conn = GetConnection())
            using(SqlCommand cmd = new SqlCommand(sql.ToString(), conn))
            {
                conn.Open();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return this.SetEmployeeDto(dt);
            }
        }
        public List<EmployeeDto> GetDepartmentEmployees(List<int> departmentCodes)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * ");
            sql.Append("FROM Attendance.dbo.Employee ");
            sql.Append("WHERE ");
            string inValue = string.Join(",", departmentCodes);
            sql.Append("departmentCode IN(" + inValue + ")");

            return this.GetEmployees(departmentCodes, sql);
        }

        public List<EmployeeDto> GetSelectedEmployees(List<int> employeeCodes)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * ");
            sql.Append("FROM Attendance.dbo.Employee ");
            sql.Append("WHERE ");
            string inValue = string.Join(",", employeeCodes);
            sql.Append("code IN(" + inValue + ")");

            return this.GetEmployees(employeeCodes, sql);
        }

        // 一人検索用
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
                return this.SetEmployeeDto(dt)[0];
            }
        }


    }
}
