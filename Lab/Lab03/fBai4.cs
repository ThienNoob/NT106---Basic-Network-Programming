using Lab3;
using System.Net;
using System.Windows.Forms;

namespace Project
{
    public partial class fBai4 : Form
    {
        public fBai4()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBai4_Client f = new fBai4_Client();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fBai4_Server f = new fBai4_Server();
            f.Show();
        }
    }
}