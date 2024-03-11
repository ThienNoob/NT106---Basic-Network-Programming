using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Lab04
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFile.Text = "";
            txtURL.Text = "";
            rtxtWeb.Text = "";
            btnDownload.Select();
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            try
            {
                Stream response = myClient.OpenRead(txtURL.Text);
                myClient.DownloadFile(txtURL.Text, txtFile.Text);
                MessageBox.Show("File downloaded");
                rtxtWeb.Text = ReadFile(txtFile.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string ReadFile(string File)
        {
            StreamReader sr = new StreamReader(File);
            string str = sr.ReadToEnd();
            sr.Close();
            return str;
        }
    }
}
