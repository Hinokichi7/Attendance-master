using Attendance_APP.Dao;
using Attendance_APP.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_APP
{
    public partial class SignIn : Form
    {
        //public EmployeeDto Employee { get; set; }
        public SignIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // ID・パスワード照合
        private EmployeeDto GetEmployee()
        {
            Regex pattarn = new Regex(@"[0-9]{3}");
            var match = pattarn.IsMatch(tb_code.Text);
            try
            {
                if (pattarn.IsMatch(tb_code.Text))
                {
                    int code = int.Parse(tb_code.Text);
                    EmployeeDto employee = new EmployeeDao().GetSelectedEmployee(code);
                    if(employee.Password == tb_password.Text)
                    {
                        return employee;
                    }
                    else
                    {
                        MessageBox.Show("IDかパスワードが正しくありません。");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("半角数字で3桁で入力してください。");
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("IDかパスワードが正しくありません。");
                return null;
            }
        }



        private void btn_stamping_Click_1(object sender, EventArgs e)
        {
            EmployeeDto employee = this.GetEmployee();
            if (employee != null)
            {
                new Stamping(employee).ShowDialog(this);
                tb_code.Text = "";
                tb_password.Text = "";
            }

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            EmployeeDto employee = this.GetEmployee();
            if (employee != null && employee.AdminFlug == 1)
            {
                new AdminMenu(employee).ShowDialog(this);
                tb_code.Text = "";
                tb_password.Text = "";
            }
            else
            {
                MessageBox.Show("管理権限がありません。");
            }

        }
    }
}
