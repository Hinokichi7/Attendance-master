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

        // パスワード照合
        private EmployeeDto GetEmployee()
        {
            try
            {
                return new EmployeeDao().GetAllEmployee().Find(employee => employee.Password == tb_password.Text);
            }
            catch
            {
                return null;
            }
        }


        private void btn_stamping_Click_1(object sender, EventArgs e)
        {
            EmployeeDto employee = this.GetEmployee();
            if (employee != null)
            {
                new Stamping(employee).ShowDialog(this);
                tb_password.Text = "";
            }
            else
            {
                MessageBox.Show("正しいパスワードを入力してください。");
            }
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            EmployeeDto employee = this.GetEmployee();
            if (employee != null && employee.AdminFlug == 1)
            {
                new AdminMenu(employee).ShowDialog(this);
                tb_password.Text = "";
            }
            else
            {
                MessageBox.Show("正しいパスワードを入力してください。");
            }
        }

    }
}
