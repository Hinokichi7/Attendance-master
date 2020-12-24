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
        }
    }
}
