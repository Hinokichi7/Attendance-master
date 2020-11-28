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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            new AdminMenu().ShowDialog(this);
        }

        private void btn_stamping_Click_1(object sender, EventArgs e)
        {
            var stamping = new Stamping();
            stamping.ShowDialog(this);
        }
    }
}
