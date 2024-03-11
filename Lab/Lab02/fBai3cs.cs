using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Lab2
{
    public partial class fBai3cs : Form
    {
        public fBai3cs()
        {
            InitializeComponent();
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("input3.txt",FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    rtbInput.Text = "\n" + sr.ReadToEnd();
                }

            }
  
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs1 = new FileStream("input3.txt", FileMode.Open);
            FileStream fs2 = new FileStream("output3.txt", FileMode.Create);
            StreamReader sr = new StreamReader(fs1);
            StreamWriter sw = new StreamWriter(fs2);
            DataTable dt = new DataTable();
            string[] strArr = sr.ReadToEnd().Split('\n');
            foreach (string str in strArr)
            {
                var kq = dt.Compute(str, "");
                string strKQ = kq.ToString();
                double f;
               
                f = float.Parse(strKQ);
                f = Math.Round(f, 2);
                string str1 = str.Remove(str.Length - 1) + " = " + f;
                sw.WriteLine(str1);
               
            }    
            
            sw.Flush();
            fs1.Close();
            fs2.Close();
            MessageBox.Show("Đã ghi file thành công");
            



        }

        private void btnReadOutput_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output3.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            rtbOutput.Text="\n" + sr.ReadToEnd();
            fs.Close();
        }
    }
}
