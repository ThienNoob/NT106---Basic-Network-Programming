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
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void btPOST_Click(object sender, EventArgs e)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://www.contoso.com/PostAccepter.aspx");
                request.Method = "POST";
                request.Timeout = 300000; // thời gian chờ 300s

                string postData = tbData.Text;
                byte[] data = Encoding.UTF8.GetBytes(postData);

                request.ContentLength = data.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(data, 0, data.Length);
                }
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            string dataString = reader.ReadToEnd();
                            rtbXuat.Text = String.Empty;
                            rtbXuat.Text = dataString;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
