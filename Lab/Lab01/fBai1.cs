using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class fBai1 : Form
    {
        public fBai1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int num1=0,num2=0;
            if (Int32.TryParse(tb1.Text, out num1) && Int32.TryParse(tb2.Text, out num2))
                tbkq.Text = "" + (num1 + num2);
            else
                MessageBox.Show("Vui lòng nhập số nguyên !");
                    

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
