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
    public partial class CmbEmployees : UserControl
    {
        private List<DepartmentDto> SelectedDepartment { get; set; }
        public List<EmployeeDto> SelectedEmployees { get; set; }

        public CmbEmployees()
        {
            InitializeComponent();
            this.SetCmbDepartment();
        }

        private void SetCmbDepartment()
        {
            cmb_department.Items.Add("(全部署)");
            var departments = new DepartmentDao().GetAllDepartment();
            foreach (var department in departments)
            {
                cmb_department.Items.Add(department.Name);
            }
        }

        private void SetSelectedDepartment()
        {
            if (cmb_department.SelectedIndex == 0)
            {
                this.SelectedDepartment = new DepartmentDao().GetAllDepartment();
            } else
            {
                this.SelectedDepartment = new DepartmentDao().GetSelectedDepartment(cmb_department.SelectedItem.ToString());
            }
        }


        private void cmb_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_employee.Items.Clear();
            this.SetSelectedDepartment();
            this.SetCmbEmployee();
        }

        public List<int> GetDepartmentCodes()
        {
            List<int> departmentCodes = new List<int>();
            foreach (var department in this.SelectedDepartment)
            {
                departmentCodes.Add(department.Code);
            }
            return departmentCodes;
        }

        private void SetCmbEmployee()
        {
            cmb_employee.Items.Add("(全員)");
            if (cmb_department.SelectedIndex == 0)
            {
                List<EmployeeDto> employees = new EmployeeDao().GetAllEmployee();
                foreach (var employee in employees)
                {
                    cmb_employee.Items.Add(employee.Name);
                }
            }
            else
            {
                this.SelectedEmployees = new EmployeeDao().GetDepartmentEmployee(this.GetDepartmentCodes());
                foreach (var employee in this.SelectedEmployees)
                {
                    cmb_employee.Items.Add(employee.Name);
                }
            }
        }

        public List<int> GetEmployeeCodes()
        {
            List<int> employeeCodes = new List<int>();
            foreach (var employee in this.SelectedEmployees)
            {
                employeeCodes.Add(employee.Code);
            }
            return employeeCodes;
        }

        public void SetSelectedEmployee()
        {
            if(cmb_department.SelectedIndex == 0 && cmb_employee.SelectedIndex == 0)
            {
                this.SelectedEmployees = new EmployeeDao().GetAllEmployee();
            }
            else if (cmb_employee.SelectedIndex == 0)
            {
                this.SelectedEmployees = new EmployeeDao().GetSelectedEmployees(this.GetEmployeeCodes());
            }
            else
            {
                this.SelectedEmployees = new EmployeeDao().GetSelectedEmployees(this.GetEmployeeCodes());
            }
        }


        private void cmb_employee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.SetSelectedEmployee();
        }

    }
}
