using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class fBai5 : Form
    {
        public fBai5()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            fBai5_Server f = new fBai5_Server();
            f.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            fBai5_Client f = new fBai5_Client();
            f.Show();
        }
    }
}
