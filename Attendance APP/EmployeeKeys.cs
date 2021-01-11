using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    // キーをハッシュ表に配置する
    class EmployeeKeys : IEquatable<EmployeeKeys>
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int DepartmentCode { get; set; }
        public string Password { get; set; }
        public int AdminFlug { get; set; }

        public EmployeeKeys(int code, string name, int departmentCode, string password, int adminFlug)
        {
            this.Code = code;
            this.Name = name;
            this.DepartmentCode = departmentCode;
            this.Password = password;
            this.AdminFlug = adminFlug;
        }


        // オブジェクト同士の同値性の確認
        public  bool Equals(EmployeeKeys other)
        {
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (other == null || this.GetType() != other.GetType())
            {
                return false;
            }

            return this.Code == other.Code && this.Name == other.Name && this.DepartmentCode == other.DepartmentCode && this.Password == other.Password && this.AdminFlug == other.AdminFlug;
        }

        // オブジェクトに重複しないハッシュコードを振り分ける
        public override int GetHashCode()
        {
            return
                Code.GetHashCode() ^
                Name.GetHashCode() ^
                DepartmentCode.GetHashCode() ^
                Password.GetHashCode() ^
                AdminFlug.GetHashCode();
        }
    }
}
