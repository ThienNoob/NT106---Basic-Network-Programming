using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonBai1_Click(object sender, EventArgs e)
        {
            Bai01 formBai1 = new Bai01();
            formBai1.ShowDialog();
        }

        private void buttonBai2_3_Click(object sender, EventArgs e)
        {
            Bai02_03 formBai02_03 = new Bai02_03();
            formBai02_03.ShowDialog();
        }

        private void buttonBai4_Click(object sender, EventArgs e)
        {
            Bai04 formBai04 = new Bai04();
            formBai04.ShowDialog();
        }
    }
}
