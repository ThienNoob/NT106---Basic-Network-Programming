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
    public partial class fBai5 : Form
    {
        public fBai5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        public long LuyThua(int n)
        {
            long kq = 1;
            for (int i=2;i<=n;i++)
                kq*= i;
            return kq;
        }
        public int TinhTong(int n)
        {
            int kq = 0;
            for (int i = 0; i <= n; i++)
                kq += i;
            return kq;
        }

        public int TinhGiaiThua(int a,int b)
        {
            int kq = 1;
            for (int i=0;i<b;i++)
                kq *= a;
            return kq;
        }
        public int TinhS3(int a,int b)
        {
            int S3 = 0;
            for (int i = 1; i <= b; i++)
                S3 += TinhGiaiThua(a, i);
            return S3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            
            string kq1 = "", kq2 = "", kq3 = "", kq4 = "", kq5 = "";
            if (Int32.TryParse(textBox1.Text, out a) && Int32.TryParse(textBox2.Text, out b))
            {
                
                kq1 = "A! = " + String.Format("{0:#,##0}", LuyThua(a));
                kq2 = "B! = " + String.Format("{0:#,##0}", LuyThua(b));
                kq3 = "S1 = 1 + 2 + ... + A = " + TinhTong(a);
                kq4 = "S2 = 1 + 2 + ... + B = " + TinhTong(b);
                kq5 = "S3 = A^1 + A^2 + ... + A^B = " + TinhS3(a, b);



                textBox3.Text =Environment.NewLine+  kq1 + "                         " + kq2 + Environment.NewLine + kq3 + Environment.NewLine + kq4 + Environment.NewLine + kq5;

            }
            else
                MessageBox.Show("Vui lòng nhập số nguyên !");




        }
    }
}
