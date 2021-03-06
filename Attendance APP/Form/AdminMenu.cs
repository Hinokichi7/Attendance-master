﻿using Attendance_APP.Admin;
using Attendance_APP.Dao;
using Attendance_APP.Dto;
using System;
using System.Windows.Forms;

namespace Attendance_APP
{
    public partial class AdminMenu : Form
    {

        public AdminMenu(EmployeeDto employee)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = "管理者 [" + employee.Name +"]";
        }


        private void EditRecord_Click(object sender, EventArgs e)
        {
            new RecordMenu().ShowDialog(this);
        }

        private void Output_Click(object sender, EventArgs e)
        {
            var csvOutput = new OutPutMenu();
            csvOutput.ShowDialog(this);
        }

        private void EditMaester_Click(object sender, EventArgs e)
        {
            new EmployeeDictionary().xxx();
            new MasterMenu().ShowDialog(this);
        }

        private void Input_Click(object sender, EventArgs e)
        {
            new InputMenu().ShowDialog(this);
        }
    }
}
