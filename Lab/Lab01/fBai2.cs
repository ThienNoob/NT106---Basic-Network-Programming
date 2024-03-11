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
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fBai2_Load(object sender, EventArgs e)
        {

        }
        double MAX(double a, double b, double c)
        {
            if (a >= b && a >= c)
                return a;
            else if (b >= c) 
                return b;
            else return c;  
             
        }
        double MIN(double a, double b, double c)
        {
            if (a <= b && a <= c)
                return a;
            else if (b <= c)
                return b;
            else return c;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, num3=0;
            if (Double.TryParse(tb_so1.Text, out num1) && Double.TryParse(tb_so2.Text, out num2) && Double.TryParse(tb_so3.Text, out num3))
            {
                tb_max.Text = "" + MAX(num3, num1, num2);

                tb_min.Text = "" + MIN(num3, num1, num2);
            }    
            else
                MessageBox.Show("Vui lòng nhập số nguyên !");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_so1.Text = "";
            tb_so2.Text = "";
            tb_so3.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
