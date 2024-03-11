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
    public partial class fBai3_1 : Form
    {
        public fBai3_1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        public string Doc3So(long num)
        {
            string kq = "";
            int flag1 = 0;
            int flag2 = 0;
          
            string[] donvi = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] chuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] tram = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
            if (num == 0)
                kq = "không";
            if (num >= 100)
            {
                kq += tram[num / 100] + " ";
                flag1 = 1;

                num %= 100;
            }
            if (num >= 10)
            {
                if (num >= 20 || num % 10 == 0)
                {
                    kq += chuc[num / 10] + " ";
                    flag2 = 1;
                    
                    num %= 10;
                }
                else
                {
                    kq += "mười ";
                    flag2 = 1;
             
                    num %= 10;
                }
            }

            if (num > 0)
            {
                if (num == 1 && kq != "" && flag1==0)
                {
                    kq += "mốt";
                }
                else if (num == 5 && kq != "" && flag1 == 0)
                {
                    kq += "lăm";
                }
                else
                {
                    if (flag1 ==1 && flag2==0)
                        kq += "linh " + donvi[num];
                    else 
                        kq +=donvi[num];



                }

            }
            return kq;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            long num = 0;
            string kq = "";

            if (Int64.TryParse(textBox1.Text, out num) && (num >= 0 && num <= 999999))
            {

                if (num >= 1000)
                {
                    kq = Doc3So(num / 1000) + " nghìn, ";
                    num %= 1000;
                }
                    
            

                  kq += Doc3So(num);
    

                  textBox2.Text = kq;

            }


            else
                MessageBox.Show("Vui lòng nhập số nguyên từ 0-999999!");
        }
    }
}
