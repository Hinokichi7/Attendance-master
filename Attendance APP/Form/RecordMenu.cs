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
                this.StampingTable = new StampingDao().GetSerchedStamping(cmbEmployee21.GetSelectedEmployeeCodes(), startPoint, endPoint);
                dataGridView1.DataSource = this.StampingTable;
                //表示設定
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dataGridView1.Columns["attendance"].DefaultCellStyle.Format = "HH:mm";
                dataGridView1.Columns["leavingWork"].DefaultCellStyle.Format = "HH:mm";
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["updateTime"].Visible = false;
                dataGridView1.Columns["stampingCode"].Visible = false;
                dataGridView1.Columns["name"].HeaderText = Program.title_department;
                dataGridView1.Columns["employeeCode"].HeaderText = Program.title_employeeCode;
                dataGridView1.Columns["Name1"].HeaderText = Program.title_Name;
                dataGridView1.Columns["year"].HeaderText = Program.title_Year;
                dataGridView1.Columns["month"].HeaderText = Program.title_Month;
                dataGridView1.Columns["day"].HeaderText = Program.title_Day;
                dataGridView1.Columns["attendance"].HeaderText = Program.title_attendance;
                dataGridView1.Columns["leavingWork"].HeaderText = Program.title_leavingWork;
                dataGridView1.Columns["StampingName"].HeaderText = Program.title_stampingName;
                dataGridView1.Columns["workingHours"].HeaderText = Program.title_workingHours;
                dataGridView1.Columns["remark"].HeaderText = Program.title_remark;

                // 検索結果0件の場合
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("打刻データがありません。");
                }
            }// 検索条件が取得できなかった場合
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
