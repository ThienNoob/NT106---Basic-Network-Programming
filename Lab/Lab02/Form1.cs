namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fBai1 f = new fBai1();
            f.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fBai2 f = new fBai2();
            f.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fBai3cs f = new fBai3cs();
            f.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fBai4cs f = new fBai4cs();
            f.Show();

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            fBaif5 f = new fBaif5();
            f.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            fBai6 f=new fBai6();
            f.Show();

        }
    }
}