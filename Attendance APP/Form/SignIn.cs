using Attendance_APP.Dao;
using Attendance_APP.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_APP
{
    public partial class SignIn : Form
    {
        public EmployeeDto Employee { get; set; }
        public SignIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // 入力フォームから社員番号を取得
        private int? GetPassNumber()
        {
            int passnumber;
            if(int.TryParse(tb_password.Text.Substring(tb_password.Text.Length - 3), out passnumber))
            {
                return passnumber;
            }
            else
            {
                return null;
            }
        }

        // コードから社員を取得
        private void SetEmployee(int? code)
        {
            if(code != null)
            {
            this.Employee = new EmployeeDao().GetAllEmployee().Find(employee => employee.Code == code);
            }
        }

        // 管理者コードから社員を取得
        private void SetAdministor()
        {
            int? passnumber = this.GetPassNumber();
            if(passnumber != null)
            {
            var administorList = new List<int>() { 1, 3, 6 };
            var adminstorCode = administorList.Find(administor => administor == passnumber);
            this.SetEmployee(adminstorCode);
            }
        }


        private void btn_stamping_Click_1(object sender, EventArgs e)
        {
            this.SetEmployee(this.GetPassNumber());
            if (tb_password.Text.Substring(0,6) == "dakoku" && this.Employee != null)
            {
                var stamping = new Stamping(this.Employee);
                stamping.ShowDialog(this);
                tb_password.Text = "";
            }
            else
            {
                MessageBox.Show("正しいパスワードを入力してください。");
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.SetAdministor();
            if (tb_password.Text.Substring(0,5) == "kanri" && this.Employee != null)
            {
                new AdminMenu(this.Employee).ShowDialog(this);
                tb_password.Text = "";
            }
            else
            {
                MessageBox.Show("正しいパスワードを入力してください。");
            }
        }
    }
}
