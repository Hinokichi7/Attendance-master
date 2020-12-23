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

        public void SetGridView(List<int> ids)
        {
            this.StampingTable = new StampingDao().GetInputStamping(ids);
            dataGridView1.DataSource = this.StampingTable;
        }

    }
}
