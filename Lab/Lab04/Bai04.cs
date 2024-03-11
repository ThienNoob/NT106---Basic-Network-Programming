using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Net;

namespace Lab04
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
            txtURL.Select();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadWeb();
                btnHome.Select();
            }
        }
        private void LoadWeb()
        {
            webView21.Source = new Uri(txtURL.Text);
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.com");
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
            {
                webView21.GoForward();
            }
        }
        private void btnViewSource_Click(object sender, EventArgs e)
        {
            Ba0i4_ViewSource f = new Ba0i4_ViewSource();
            f.txtURLView.Text = txtURL.Text;
            f.txtWEBView.Text = getHTML(txtURL.Text);
            f.Text = "View source";
            f.Show();
        }
        private string getHTML(string szURL)
        {
          
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    WebClient myClient = new WebClient();
                    string fileName = saveFileDialog.FileName;
                    Stream response = myClient.OpenRead(txtURL.Text);
                    myClient.DownloadFile(txtURL.Text, fileName);
                    MessageBox.Show("Fiel được lưu tại: " + fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
