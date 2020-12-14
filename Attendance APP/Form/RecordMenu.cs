using Attendance_APP.Dao;
using Attendance_APP.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Attendance_APP.Admin
{
    public partial class RecordMenu : Form
    {
        DataTable StampingTable { get; set; }
        DataGridViewSelectedRowCollection SelectedRows { get; set; }
        List<EmployeeDto> Employees { get; set; }

        public RecordMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }


        private void SetGredView()
        {
            this.Employees = cmbEmployee21.SelectedEmployees;

            var startPoint = cmbDate1.GetSelectedPoint();
            var endPoint = cmbDate2.GetSelectedPoint();
            if (this.Employees != null && cmbDate1.GetSelectedDate() <= cmbDate2.GetSelectedDate())
            {
                this.StampingTable = new StampingDao().GetSerchedStamping2(cmbEmployee21.GetEmployeeCodes(), startPoint, endPoint);
                dataGridView1.DataSource = this.StampingTable;

                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

                dataGridView1.Columns["attendance"].DefaultCellStyle.Format = "HH:mm";
                dataGridView1.Columns["leavingWork"].DefaultCellStyle.Format = "HH:mm";
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["stampingCode"].Visible = false;
                dataGridView1.Columns["name"].HeaderText = "部署";
                dataGridView1.Columns["employeeCode"].HeaderText = "社員番号";
                dataGridView1.Columns["Name1"].HeaderText = "氏名";
                dataGridView1.Columns["year"].HeaderText = "年";
                dataGridView1.Columns["month"].HeaderText = "月";
                dataGridView1.Columns["day"].HeaderText = "日";
                dataGridView1.Columns["attendance"].HeaderText = "出勤時間";
                dataGridView1.Columns["leavingWork"].HeaderText = "退勤時間";
                dataGridView1.Columns["StampingName"].HeaderText = "勤務種別";
                dataGridView1.Columns["workingHours"].HeaderText = "勤務時間";
                dataGridView1.Columns["remark"].HeaderText = "備考";

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("打刻データがありません。");
                }
            }
            else
            {
                MessageBox.Show("検索条件が正しく選択されていません。");
            }
        }

        private List<StampingDto> GetSelectedRecords()
        {
            var stamping = new StampingDao().SetStampingDto(this.StampingTable);
            this.SelectedRows = dataGridView1.SelectedRows;
            List<StampingDto> SelectStampings = new List<StampingDto>();
            for (var i = 0; i < this.SelectedRows.Count; i++)
            {
                SelectStampings.Add(stamping[this.SelectedRows[i].Index]);
            }
            return SelectStampings;
        }


        private void serch_Click(object sender, EventArgs e)
        {
            this.SetGredView();
        }

        private void edit_Click_1(object sender, EventArgs e)
        {
            var selectStampings = this.GetSelectedRecords();
            if(this.SelectedRows.Count == 1)
            {
                var editRecordForm = new EditRecord(this.Employees[0], selectStampings);

                if (System.Windows.Forms.DialogResult.OK == editRecordForm.ShowDialog())
                {
                    this.SetGredView();
                }
            }
            else
            {
                MessageBox.Show("編集する打刻レコードを1行選択してください。");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            var stamping = new StampingDao().SetStampingDto(this.StampingTable);
            this.SelectedRows = dataGridView1.SelectedRows;
            string message = "";
            var selectStampings = this.GetSelectedRecords();
            if (this.SelectedRows.Count != 0)
            {
                foreach(var selectStamping in selectStampings)
                {
                    message += "\n" + selectStamping.Attendance.ToString("yyyy/MM/dd");
                }
                DialogResult result = MessageBox.Show(message + "のレコードを削除します。", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    foreach (var selectStamping in selectStampings)
                    {
                        new StampingDao().DeleteRecord(selectStamping);
                    }
                }
                this.SetGredView();
            }


        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
            new NewRecord().ShowDialog(this);
        }
    }
}
