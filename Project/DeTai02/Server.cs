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
using System.Net.Sockets;
using System.Threading;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections;

namespace DeTai02
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            buttonListen.Focus();
        }
        UdpClient udpClient;
        Thread thdUDPServer;
        public void serverThread()
        {
            try
            {
                udpClient = new UdpClient(12345);
                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    string response = Translate(returnData);
                    byte[] responseData = Encoding.UTF8.GetBytes(response);
                    udpClient.Send(responseData, responseData.Length, RemoteIpEndPoint);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string Translate(string s)
        {
            string[] strings = s.Split(',');
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            listBoxMessages.Items.Add(formattedTime + ": " + strings[2]);
            string url = String.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", strings[0], strings[1], Uri.EscapeUriString(strings[2]));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = JsonConvert.DeserializeObject<List<dynamic>>(result);

            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }
        private void buttonListen_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                thdUDPServer = new Thread(new ThreadStart(serverThread));
                thdUDPServer.Start();
                buttonListen.BackColor = Color.Lime;
                buttonListen.Text = "Listening...";
                buttonListen.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                udpClient.Close();
                thdUDPServer?.Abort();
                this.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
