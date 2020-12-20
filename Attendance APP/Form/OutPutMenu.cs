using Attendance_APP.Dao;
using Attendance_APP.Dto;
using Attendance_APP.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Attendance_APP
{
    public partial class OutPutMenu : Form
    {
        DataTable StampingTable { get; set; }
        DataGridViewSelectedRowCollection SelectedRows { get; set; }
        List<EmployeeDto> Employees { get; set; }
        public const string title_department = "部署";
        public const string title_employeeCode = "社員番号";
        public const string title_Name = "氏名";
        public const string title_Year = "年";
        public const string title_Month = "月";
        public const string title_Day = "日";
        public const string title_attendance = "出勤時間";
        public const string title_leavingWork = "退勤時間";
        public const string title_stampingName = "勤務種別";
        public const string title_workingHours = "勤務時間";
        public const string title_remark = "備考";

        public OutPutMenu()
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
                dataGridView1.Columns["name"].HeaderText = title_department;
                dataGridView1.Columns["employeeCode"].HeaderText = title_employeeCode;
                dataGridView1.Columns["Name1"].HeaderText = title_Name;
                dataGridView1.Columns["year"].HeaderText = title_Year;
                dataGridView1.Columns["month"].HeaderText = title_Month;
                dataGridView1.Columns["day"].HeaderText = title_Day;
                dataGridView1.Columns["attendance"].HeaderText = title_attendance;
                dataGridView1.Columns["leavingWork"].HeaderText = title_leavingWork;
                dataGridView1.Columns["StampingName"].HeaderText = title_stampingName;
                dataGridView1.Columns["workingHours"].HeaderText = title_workingHours;
                dataGridView1.Columns["remark"].HeaderText = title_remark;

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

        private List<int> GetStampingId()
        {
            List<int> ids = new List<int>();
            foreach( DataRow dr in this.StampingTable.Rows)
            {
                int id;
                id = int.Parse(dr["id"].ToString());
                ids.Add(id);
            }
            return ids;
        }

        private void outputCsv_Click(object sender, EventArgs e)
        {
            // 選択された年月日の数値を日付に変換
            var date1 = cmbDate1.GetSelectedDate();
            var date2 = cmbDate2.GetSelectedDate();
            // 期間開始と終了が正しく選択できていれば保存
            if (date1 < date2)
            {
                // 年月日の数字をSQL期間指定用文字列へ
                var starPoint = cmbDate1.GetSelectedPoint();
                var endPoint = cmbDate2.GetSelectedPoint();
                new OutputFile().SaveFileDialog(this.GetStampingId());
            }
            else
            {
                MessageBox.Show("正しい期間を選択してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchRecord_Click(object sender, EventArgs e)
        {
            this.SetGredView();
        }
    }
}
