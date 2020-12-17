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
    public partial class CmbEmployee : UserControl
    {
        private List<DepartmentDto> SelectedDepartment { get; set; }
        public List<EmployeeDto> SelectedEmployees { get; set; }

        public CmbEmployee()
        {
            InitializeComponent();
            this.SetCmbDepartment();
        }

        private void SetCmbDepartment()
        {
            cmb_department.DataSource = new DepartmentDao().GetAllDepartment();
            cmb_department.ValueMember = "Name";
            cmb_department.DisplayMember = "Name";
            cmb_department.SelectedIndex = -1;
        }

        private void SetSelectedDepaetment()
        {
            this.SelectedDepartment = new DepartmentDao().GetSelectedDepartment(cmb_department.SelectedValue.ToString());
        }

        private void cmb_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.SetSelectedDepaetment();
            this.SetCmbEmployee();
        }

        public List<int> GetDepaetmentCodes()
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
            this.SelectedEmployees = new EmployeeDao().GetDepartmentEmployees(this.GetDepaetmentCodes());
            cmb_employee.DataSource = this.SelectedEmployees;
            cmb_employee.ValueMember = "Code";
            cmb_employee.DisplayMember = "Name";
            cmb_employee.SelectedIndex = -1;
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
            this.SelectedEmployees = new EmployeeDao().GetSelectedEmployees(this.GetEmployeeCodes());
        }


        private void cmb_employee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.SetSelectedEmployee();
        }
    }
}
