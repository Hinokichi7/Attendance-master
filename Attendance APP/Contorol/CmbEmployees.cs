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
        private List<EmployeeDto> DepaetmentEmployees { get; set; }
        public List<EmployeeDto> SelectedEmployees { get; set; }

        public CmbEmployees()
        {
            InitializeComponent();
            this.SetCmbDepartment();
            this.SelectedDepartment = new DepartmentDao().GetAllDepartment();
            this.SetCmbEmployee();
        }

        private List<DepartmentDto> GetDepartmentList()
        {
            List<DepartmentDto> departmentList = new DepartmentDao().GetAllDepartment();
            DepartmentDto allDepartment = new DepartmentDto();
            allDepartment.Code = 0;
            allDepartment.Name = "全部署";
            departmentList.Insert(0, allDepartment);
            return departmentList;
        }
        private void SetCmbDepartment()
        {
            cmb_department.DataSource = this.GetDepartmentList();
            cmb_department.ValueMember = "Code";
            cmb_department.DisplayMember = "Name";
        }


        private void SetSelectedDepartment()
        {
            if (cmb_department.SelectedIndex == 0)
            {
                this.SelectedDepartment = new DepartmentDao().GetAllDepartment();
            } else
            {
                this.SelectedDepartment = new DepartmentDao().GetSelectedDepartment(int.Parse(cmb_department.SelectedValue.ToString()));
            }
        }


        private void cmb_department_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //cmb_employee.Items.Clear();
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

        private List<EmployeeDto> GetEmployeeList()
        {
            List<EmployeeDto> employeeList = new EmployeeDao().GetDepartmentEmployees(this.GetDepartmentCodes());
            EmployeeDto allEmployee = new EmployeeDto();
            allEmployee.Code = 0;
            allEmployee.Name = "全員";
            allEmployee.DepartmentCode = 0;
            allEmployee.AdminFlug = 0;
            employeeList.Insert(0, allEmployee);
            return employeeList;
        }

        private void SetCmbEmployee()
        {
            cmb_employee.DataSource = this.GetEmployeeList();
            cmb_employee.ValueMember = "Code";
            cmb_employee.DisplayMember = "Name";
        }

        public void SetSelectedEmployee()
        {
            // 全部署,全員
            if(cmb_department.SelectedIndex == 0 && cmb_employee.SelectedIndex == 0)
            {
                this.SelectedEmployees = new EmployeeDao().GetAllEmployee();
            }
            // 部署, 全員
            else if(cmb_department.SelectedIndex != 0 && cmb_employee.SelectedIndex == 0)
            {
                this.SelectedEmployees = new EmployeeDao().GetDepartmentEmployees(GetDepartmentCodes());
            }
            // それ以外
            else
            {
                int selectedCode = int.Parse(cmb_employee.SelectedValue.ToString());
                EmployeeDto selectedEmployee = new EmployeeDao().GetSelectedEmployee(selectedCode);
                this.SelectedEmployees = new List<EmployeeDto>();
                this.SelectedEmployees.Add(selectedEmployee);
            }
        }


        private void cmb_employee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.SetSelectedEmployee();
        }
        // 選択された社員のコードを取得
        public List<int> GetSelectedEmployeeCodes()
        {
            List<int> employeeCodes = new List<int>();
            foreach (var employee in this.SelectedEmployees)
            {
                employeeCodes.Add(employee.Code);
            }
            return employeeCodes;
        }

    }
}
