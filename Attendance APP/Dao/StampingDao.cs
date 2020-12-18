using Attendance_APP.Dto;
using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attendance_APP.Dao
{
    class StampingDao : Dao
    {
        public List<StampingDto> SetStampingDto(DataTable dt)
        {
            List<StampingDto> list = new List<StampingDto>();
            foreach(DataRow dr in dt.Rows)
            {
                StampingDto dto = new StampingDto();

                dto.Id = int.Parse(dr["id"].ToString());
                if (!String.IsNullOrEmpty(dr["createTime"].ToString()))
                {
                    dto.CreateTime = DateTime.Parse(dr["createTime"].ToString());
                }
                if (!String.IsNullOrEmpty(dr["updateTime"].ToString()))
                {
                    dto.UpdateTime = DateTime.Parse(dr["updateTime"].ToString());
                }
                dto.EmployeeCode = int.Parse(dr["employeeCode"].ToString());
                dto.Year = int.Parse(dr["year"].ToString());
                dto.Month = int.Parse(dr["month"].ToString());
                dto.Day = int.Parse(dr["day"].ToString());
                dto.Attendance = DateTime.Parse(dr["attendance"].ToString());
                if (!String.IsNullOrEmpty(dr["leavingWork"].ToString()))
                {
                    dto.LeavingWork = DateTime.Parse(dr["leavingWork"].ToString());
                }
                dto.StampingCode = int.Parse(dr["stampingCode"].ToString());
                if (!String.IsNullOrEmpty(dr["workingHours"].ToString()))
                {
                    dto.WorkingHours = int.Parse(dr["workingHours"].ToString());
                }
                if (!String.IsNullOrEmpty(dr["remark"].ToString()))
                {
                    dto.Remark = dr["remark"].ToString();
                }

                list.Add(dto);
            }
            return list;
        }

        public DataTable GetSerchedStamping(List<int> employeeCodes, string startPoint, string endPoint)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT ");
            // カラム
            sql.Append("tbS.createTime, ");
            sql.Append("tbS.updateTime, ");
            sql.Append("tbD.name, ");
            sql.Append("tbS.id, ");
            sql.Append("tbS.employeeCode, ");
            sql.Append("tbE.Name, ");
            sql.Append("tbS.year, ");
            sql.Append("tbS.month, ");
            sql.Append("tbS.day, ");
            sql.Append("tbS.attendance, ");
            sql.Append("tbS.leavingWork, ");
            sql.Append("tbS.stampingCode, ");
            sql.Append("tbST.stampingName, ");
            sql.Append("tbS.workingHours, ");
            sql.Append("tbS.remark ");
            // テーブル
            sql.Append("FROM Attendance.dbo.Stamping as tbS, ");
            sql.Append("Attendance.dbo.StampingType as tbST, ");
            sql.Append("Attendance.dbo.Employee as tbE, ");
            sql.Append("Attendance.dbo.Department as tbD ");

            sql.Append("WHERE ");
            // 条件①:社員コード
            string inValue = string.Join(",", employeeCodes);
            sql.Append("employeeCode IN(" + inValue + ") ");
            // 条件②:期間
            sql.Append("AND attendance BETWEEN '" + startPoint + "' AND '" + endPoint + "' ");
            // 条件③:表示変更
            sql.Append("AND tbS.employeeCode = tbE.Code ");
            sql.Append("AND tbE.departmentCode = tbD.Code ");
            sql.Append("AND tbS.stampingCode = tbST.stampingCode ");
            // ソート
            sql.Append("ORDER BY employeeCode, attendance");


            // 社員を指定して最新の打刻データを読み込み
            var dt = new DataTable();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql.ToString(), conn))//using (var conn = GetConnection())を入れ子にしている
            {
                conn.Open();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
        }

        public List<StampingDto> GetTermStamping(string startPoint, string endPoint)
        {
            // 期間(文字列で指定)データを取得
            var dt = new DataTable();
            using (var conn = GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Attendance.dbo.Stamping WHERE attendance BETWEEN @startPoint AND @endPoint", conn))
            {
                cmd.Parameters.AddWithValue("@startPoint", startPoint);
                cmd.Parameters.AddWithValue("@endPoint", endPoint);
                conn.Open();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return this.SetStampingDto(dt);
            }
        }


        public StampingDto GetLatestStamping(int employeeCode)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT TOP 1 ");
            sql.Append("* FROM Attendance.dbo.Stamping ");
            sql.Append("WHERE ");
            sql.Append("employeeCode = @employeeCode ");
            sql.Append("ORDER BY id DESC");

            // 社員を指定して最新の打刻データを読み込み
            var dt = new DataTable();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(sql.ToString(), conn))
            {
                cmd.Parameters.AddWithValue("@employeeCode", employeeCode);

                conn.Open();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<StampingDto> ListStamping = this.SetStampingDto(dt);
                return (ListStamping[0]);
            }
        }



        public void AddStamping(StampingDto dto)
        {
            // 出勤打刻
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("INSERT INTO Attendance.dbo.Stamping (createTime, employeeCode, year, month, day, attendance, stampingCode) VALUES(@createTime, @employeeCode,@year, @month, @day,@attendance,@stampingCode)", conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@createTime", dto.CreateTime);
                cmd.Parameters.AddWithValue("@employeeCode", dto.EmployeeCode);
                cmd.Parameters.AddWithValue("@year", dto.Year);
                cmd.Parameters.AddWithValue("@month", dto.Month);
                cmd.Parameters.AddWithValue("@day", dto.Day);
                cmd.Parameters.AddWithValue("@attendance", dto.Attendance);
                cmd.Parameters.AddWithValue("@stampingCode", dto.StampingCode);

                cmd.ExecuteNonQuery();

            }
        }

        public void UpdateStamping(StampingDto dto)
        {
            // 退勤打刻
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("UPDATE Attendance.dbo.Stamping SET updateTime = @updateTime, leavingWork = @leavingWork, workingHours = @workingHours WHERE id = @id", conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@updateTime", dto.UpdateTime);
                cmd.Parameters.AddWithValue("@leavingWork", dto.LeavingWork);
                cmd.Parameters.AddWithValue("@workingHours", dto.WorkingHours);

                cmd.ExecuteNonQuery();

            }
        }

        public void AddNewRecord(StampingDto dto)
        {
            // 新規追加(管理)
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("INSERT INTO Attendance.dbo.Stamping (createTime, employeeCode, year, month, day, attendance, leavingwork, stampingCode, workingHours, remark) VALUES(@createTime, @employeeCode, @year, @month, @day, @attendance, @leavingWork, @stampingCode, @workingHours, @remark)", conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@createTime", dto.CreateTime);
                cmd.Parameters.AddWithValue("@employeeCode", dto.EmployeeCode);
                cmd.Parameters.AddWithValue("@year", dto.Year);
                cmd.Parameters.AddWithValue("@month", dto.Month);
                cmd.Parameters.AddWithValue("@day", dto.Day);
                cmd.Parameters.AddWithValue("@attendance", dto.Attendance);
                cmd.Parameters.AddWithValue("@leavingWork", dto.LeavingWork);
                cmd.Parameters.AddWithValue("@stampingCode", dto.StampingCode);
                cmd.Parameters.AddWithValue("@workingHours", dto.WorkingHours);
                cmd.Parameters.AddWithValue("@remark", dto.Remark);

                cmd.ExecuteNonQuery();

            }
        }



        public void UpdateEditRecord(StampingDto dto)
        {
            // 更新(管理)
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("UPDATE Attendance.dbo.Stamping SET updateTime = @updateTime, year = @year, month = @month, day = @day, attendance = @attendance, leavingwork = @leavingwork, stampingCode = @stampingCode, workingHours = @workingHours, remark = @remark WHERE id = @id", conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@updateTime", dto.UpdateTime);
                //cmd.Parameters.AddWithValue("@employeeCode", dto.EmployeeCode);
                cmd.Parameters.AddWithValue("@year", dto.Year);
                cmd.Parameters.AddWithValue("@month", dto.Month);
                cmd.Parameters.AddWithValue("@day", dto.Day);
                cmd.Parameters.AddWithValue("@attendance", dto.Attendance);
                cmd.Parameters.AddWithValue("@leavingWork", dto.LeavingWork);
                cmd.Parameters.AddWithValue("@stampingCode", dto.StampingCode);
                cmd.Parameters.AddWithValue("@workingHours", dto.WorkingHours);
                cmd.Parameters.AddWithValue("@remark", dto.Remark);

                cmd.ExecuteNonQuery();

            }
        }

        public void DeleteRecord(StampingDto dto)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM  Attendance.dbo.Stamping WHERE @id = id", conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@id", dto.Id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
