using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_APP
{
    // キーをハッシュ表に配置する
    class DtoKeys : IEquatable<DtoKeys>
    {
        public int DtoNumber { get; private set; }
        public string DtoName { get; private set; }

        public DtoKeys(int dtoNumber, string dtoName)
        {
            this.DtoNumber = dtoNumber;
            this.DtoName = dtoName;
        }

        // オブジェクト同士の同値性の確認
        public  bool Equals(DtoKeys other)
        {
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (other == null || this.GetType() != other.GetType())
            {
                return false;
            }

            return this.DtoNumber == other.DtoNumber && this.DtoName == other.DtoName;
        }

        // オブジェクトに重複しないハッシュコードを振り分ける
        public override int GetHashCode()
        {
            return
                DtoNumber.GetHashCode() ^
                DtoName.GetHashCode();
        }
    }
}
