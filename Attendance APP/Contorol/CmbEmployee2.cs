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
    public partial class CmbEmployee2 : UserControl
    {
        private DepartmentDto SelectedDepartment { get; set; }
        public List<EmployeeDto> SelectedEmployees { get; set; }
        public CmbEmployee2()
        {
            InitializeComponent();
            this.SetCmbDepartment();
        }

        public void SetCmbDepartment()
        {
            cmb_department.Items.Add("(全部署)");
            var departments = new DepartmentDao().GetAllDepartment();
            foreach(var department in departments)
            {
                cmb_department.Items.Add(department.Name);
            }
        }

        private void SetSelectedDepartment()
        {
            if(cmb_department.SelectedIndex != 0)
            {
                this.SelectedDepartment = new DepartmentDao().GetAllDepartment().Find(department => department.Name == cmb_department.SelectedItem.ToString());
            }
        }


        private void cmb_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_employee.Items.Clear();
            this.SetSelectedDepartment();
            this.SetCmbEmployee();
        }

        public void SetCmbEmployee()
        {
            if(cmb_department.SelectedIndex == 0)
            {
                cmb_employee.Items.Add("(全員)");
                this.SelectedEmployees = new EmployeeDao().GetAllEmployee();
                foreach (var employee in this.SelectedEmployees)
                {
                    cmb_employee.Items.Add(employee.Name);
                }
            }
            else
            {
                cmb_employee.Items.Add("(全員)");
                this.SelectedEmployees = new EmployeeDao().GetDepartmentEmployee(this.SelectedDepartment.Code);
                foreach(var employee in this.SelectedEmployees)
                {
                    cmb_employee.Items.Add(employee.Name);
                }
            }
        }

        public void GetSelectedEmployee()
        {
            if(cmb_employee.SelectedIndex != 0)
            {
                this.SelectedEmployees[0] = this.SelectedEmployees.Find(employee => employee.Name == cmb_employee.SelectedItem.ToString());
            }
        }

    }
}
