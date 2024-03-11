
using System.Net;
namespace Lab3
{
    public partial class fLab3 : Form
    {
        public fLab3()
        {
            InitializeComponent();
        }

      
        private void btnBai1_Click(object sender, EventArgs e)
        {
            fBai1 f = new fBai1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fBai3 f = new fBai3();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fBai2 f =new fBai2();
            f.Show();

        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            fBai5 fBai5 = new fBai5();
            fBai5.Show();
            
        }
    }

}
