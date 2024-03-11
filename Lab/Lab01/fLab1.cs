namespace Lab1
{
    public partial class fLab1 : Form
    {
        public fLab1()
        {
            InitializeComponent();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            fBai1 f = new fBai1();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fBai2 f= new fBai2();
            f.Show();

        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            fBai3 f= new fBai3();
            f.Show();
        }

        private void button3_1_Click(object sender, EventArgs e)
        {
            fBai3_1 f = new fBai3_1();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fBai4 f= new fBai4();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fBai5 f = new fBai5();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fBai8 f = new fBai8();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fBai6 f = new fBai6();
            f.Show();

        }
    }
}