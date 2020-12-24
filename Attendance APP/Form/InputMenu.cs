using Attendance_APP.Dao;
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
    public partial class InputMenu : Form
    {
        DataTable StampingTable { get; set; }
        DataGridViewSelectedRowCollection SelectedRows { get; set; }
        List<string> ReadCsv { get; set; }
        List<int> Ids { get; set; }
        public InputMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            InputFiles InputFiles = new InputFiles();
            // CSVファイル読み込み
            InputFiles.ReadFile();
            // 読み込んだ文字列のリストを取得
            this.ReadCsv = InputFiles.GetReadLines();
            // 文字列のリストからidを取得
            this.SetIds(this.ReadCsv);
            // idから一覧をセット
            this.SetGridView();
        }

        public void SetIds(List<string> readCsv)
        {
            List<int> ids = new List<int>();
            foreach (string line in readCsv)
            {
                string id = line.Substring(0, 4);
                Console.WriteLine(id);
                ids.Add(int.Parse(id));
            }
            this.Ids = ids;
        }

        public void SetGridView()
        {
            this.StampingTable = new StampingDao().GetInputStamping(this.Ids);
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
        }
    }
}
