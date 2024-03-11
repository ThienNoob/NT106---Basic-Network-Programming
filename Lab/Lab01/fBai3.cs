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
    public partial class fBai3 : Form
    {
        public fBai3()
        {
            InitializeComponent();
        }

       
        private void tb_so1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(tb_so1.Text, out num) && (num >= 0 && num <= 9))
            {


                switch (num)
                {
                    case 0:
                        tb_kq.Text = "Không";
                        break;
                    case 1:
                        tb_kq.Text = "Một";
                        break;
                    case 2:
                        tb_kq.Text = "Hai";
                        break;
                    case 3:
                        tb_kq.Text = "Ba";
                        break;
                    case 4:
                        tb_kq.Text = "Bốn";
                        break;
                    case 5:
                        tb_kq.Text = "Năm";
                        break;
                    case 6:
                        tb_kq.Text = "Sáu";
                        break;
                    case 7:
                        tb_kq.Text = "Bảy";
                        break;
                    case 8:
                        tb_kq.Text = "Tám";
                        break;
                    default:
                        tb_kq.Text = "Chín";
                        break;

                }
            }
            else
                tb_kq.Text="Vui lòng nhập số từ 0 đến 9 !";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb_so1.Text = "";
        }
    }
}
