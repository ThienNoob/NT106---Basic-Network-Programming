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
    public partial class fBai8 : Form
    {
        public fBai8()
        {
            InitializeComponent();
        }
        public int check(double[] diems,double rank)
        {
            for (int i = 0; i < diems.Length; i++)
                if (diems[i] < rank)
                    return 0;
            return 1;
        }
        public string XepLoai(double[] dDiems)
        {
            double dtb = dDiems.Average();
            if (dtb >= 8 && check(dDiems, 6.5) == 1)
                return "Giỏi";
            if(dtb >= 6.5 && check(dDiems, 5) == 1)
                return "Khá";
            if (dtb >= 5 && check(dDiems, 3.5) == 1)
                return "Trung bình";
            if (dtb >= 3.5 && check(dDiems, 2) == 1)
                return "Yếu";
            return "Kém";
        }

        public int TimViTri(double[] Diem,double k)
        {
            for (int i=0;i<Diem.Length;i++)
                if (Diem[i]==k) return i+1;
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "";
                string input = textBox1.Text;
                string[] ds = input.Split(',');
                string ten = ds[0];
                string[] diems = ds.Skip(1).ToArray();
                
                double[] dDiems = Array.ConvertAll(diems, double.Parse);

                textBox2.Text += "Họ và tên : " + ten + Environment.NewLine;
                for (int i = 0; i < dDiems.Length; i++)
                    textBox2.Text += "Môn " + (i + 1) + ": " + dDiems[i] + "   ";
                textBox2.Text += Environment.NewLine;
                textBox2.Text += "Môn điểm cao nhất: Môn " + TimViTri(dDiems, dDiems.Max()) + ": " + dDiems.Max() + "đ               Môn điểm thấp nhât: Môn " + TimViTri(dDiems, dDiems.Min()) + ": " + dDiems.Min() + "đ";
                textBox2.Text += Environment.NewLine;
                int c = 0;
                for (int i = 0; i < dDiems.Length; i++)
                    if (dDiems[i] >= 5) c++;
                textBox2.Text += "Số môn đậu: " + c + "       Số môn không đậu: " + (dDiems.Length - c);
                textBox2.Text += Environment.NewLine + "Điểm trung bình: " + string.Format("{0:n}",dDiems.Average());
                textBox2.Text += Environment.NewLine + "Xếp loại: " + XepLoai(dDiems);
            }
            catch(Exception ex)
    {
                MessageBox.Show( "Lỗi nhập dữ liệu");
            }






        }
    }
}
