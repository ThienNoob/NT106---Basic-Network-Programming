namespace Lab06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonBai03_Click(object sender, EventArgs e)
        {
            Bai03_Dashboard dashboard = new Bai03_Dashboard();
            dashboard.ShowDialog();
        }

        private void buttonBai01_Click(object sender, EventArgs e)
        {
            Bai01 formBai01 = new Bai01();
            formBai01.ShowDialog();
        }

        private void buttonBai02_Click(object sender, EventArgs e)
        {
            Bai02 formBai02 = new Bai02();
            formBai02.ShowDialog();
        }
    }
}