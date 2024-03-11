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
    public partial class fBai2 : Form
    {
        public fBai2()
        {
            InitializeComponent();
        }
        public int LineCount(string path)
        {
            int lineCount = 0;
            StreamReader sr = new StreamReader(path);
            while (sr.ReadLine() != null)
                lineCount++;
            sr.Close();
            return lineCount;

        }
        public int CharCount(string path)
        {
            int charCount = 0;
            StreamReader sr = new StreamReader(path);
            while (sr.Read() != -1)
                charCount++;
            sr.Close();
            return charCount;

        }
        public int WordCount(string path)
        {
           
            StreamReader sr = new StreamReader(path);
            string str = sr.ReadToEnd();
            string[] strArr = str.Split(',', ';', ' ', '\r' ) ;
            sr.Close();
            return strArr.Length;

        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if ( ofd.ShowDialog() == DialogResult.OK )
            {
                FileInfo fi = new FileInfo(ofd.FileName);
                tbFileName.Text = ofd.SafeFileName;
                tbSize.Text = fi.Length + " bytes";
                tbURL.Text= ofd.FileName;
                tbURL.Enabled = true;
                tbLine.Text = "" + LineCount(ofd.FileName);
                tbWords.Text = "" + WordCount(ofd.FileName);
                tbChar.Text = "" + CharCount(ofd.FileName);
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                richTextBox1.Text=sr.ReadToEnd();
                fs.Close();




            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
