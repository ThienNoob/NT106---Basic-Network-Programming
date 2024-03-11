namespace Lab04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btBai01_Click(object sender, EventArgs e)
        {
            Bai01 FormBai01 = new Bai01();
            FormBai01.ShowDialog();
        }

        private void btBai02_Click(object sender, EventArgs e)
        {
            Bai02 FormBai02 = new Bai02();
            FormBai02.ShowDialog();
        }

        private void btBai03_Click(object sender, EventArgs e)
        {
            Bai03 FormBai03 = new Bai03();
            FormBai03.ShowDialog();
        }

        private void btBai04_Click(object sender, EventArgs e)
        {
            Bai04 FormBai04 = new Bai04();
            FormBai04.ShowDialog();
        }

        private void btBai05_Click(object sender, EventArgs e)
        {
            Bai05 FormBai05 = new Bai05();
            FormBai05.ShowDialog();
        }

        private void btBai06_Click(object sender, EventArgs e)
        {
            Bai06 FormBai06 = new Bai06();
            FormBai06.ShowDialog();
        }
    }
}