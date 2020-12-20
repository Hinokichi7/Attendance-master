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
        public InputMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            new InputFiles().OpenFileDialog();
            this.GetStampingIds2();
        }

        public List<int> GetStampingIds2()
        {
            List<int> ids = new List<int>();
            foreach(string line in new InputFiles().ReadLines)
            {
                string id = line.Substring(0, 4);
                Console.WriteLine(id);
                ids.Add(int.Parse(id));
            }            
            return ids;
        }
    }
}
