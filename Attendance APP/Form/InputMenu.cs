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
        public InputMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            new InputFiles().OpenFileDialog();
        }

        public void SetIds(List<string> readLines)
        {
            List<int> ids = new List<int>();
            foreach (string line in readLines)
            {
                string id = line.Substring(0, 4);
                Console.WriteLine(id);
                ids.Add(int.Parse(id));
            }
            this.SetGridView(ids);
        }

        public void SetGridView(List<int> ids)
        {
            this.StampingTable = new StampingDao().GetInputStamping(ids);
            dataGridView1.DataSource = this.StampingTable;
        }
    }
}
