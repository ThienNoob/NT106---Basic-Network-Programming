using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class fBai1 : Form
    {
        public fBai1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input1.txt",FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            rtb1.Text= sr.ReadToEnd();
            fs.Close();

            
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("input1.txt", FileMode.Open,FileAccess.Read);
            FileStream fs2 = new FileStream("output2.txt", FileMode.Create, FileAccess.Write);
            StreamReader sr = new StreamReader(fs1);
            StreamWriter sw = new StreamWriter(fs2);
            string text = sr.ReadToEnd().ToUpper();
            sw.Write(text);
            sw.Flush();
            MessageBox.Show("Đã ghi chuyển toàn bộ kí tự trong file input1.txt sang in hoa và ghi vào file output2.txt");
            fs1.Close();
            fs2.Close();
            
        }
    }
}
