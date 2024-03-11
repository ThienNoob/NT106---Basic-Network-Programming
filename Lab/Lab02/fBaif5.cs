using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Lab2
{
    public partial class fBaif5 : Form
    {
        public fBaif5()
        {
            InitializeComponent();
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            using (ZipArchive za = ZipFile.Open("output5.zip", ZipArchiveMode.Create))
            {
                
                ZipArchiveEntry entry = za.CreateEntry("text.txt");
                using (StreamWriter sw = new StreamWriter(entry.Open()))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
            richTextBox1.Text = "";
            MessageBox.Show("Đã nén thành file output5.zip");
        }

        private void btnGiaiNen_Click(object sender, EventArgs e)
        {
            using (ZipArchive za = ZipFile.Open("output5.zip", ZipArchiveMode.Read))
            {   
                ZipArchiveEntry zae = za.GetEntry("text.txt");

                using (StreamReader sr = new StreamReader(zae.Open()))
                {
                    File.WriteAllText("output5.txt", sr.ReadToEnd());
                }    
            }
            MessageBox.Show("Đã giải nén thành file output5.txt");

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {

            using (FileStream fs = new FileStream("output5.txt", FileMode.Open))
            {
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text = "Đọc file output5.txt:\n" + sr.ReadToEnd();
            }   
        }
    }
}
