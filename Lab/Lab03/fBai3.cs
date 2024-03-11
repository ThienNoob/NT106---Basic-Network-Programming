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
    public partial class fBai3 : Form
    {
        public fBai3()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            fBai3_Server f = new fBai3_Server();
            f.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            fBai3_Client f = new fBai3_Client();
            f.Show();
        }
    }
}
