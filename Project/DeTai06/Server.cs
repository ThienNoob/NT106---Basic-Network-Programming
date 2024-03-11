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

namespace DeTai06
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            textBoxIP.Focus();
            SetDNS();
        }
        TcpListener server = null;
        TcpClient client = new TcpClient();
        public class DNS
        {
            public string hostname { get; set; }
            public string IP { get; set; }
            public DNS(string hostname, string iP)
            {
                this.hostname = hostname;
                IP = iP;
            }
        }
        DNS[] dns = new DNS[3];
        public void SetDNS()
        {
            dns[0] = new DNS("www.google.com", "8.8.8.8");
            dns[1] = new DNS("www.youtube.com", "208.67.222.222");
            dns[2] = new DNS("www.facebook.com", "8.8.4.4");
        }
        private void buttonListen_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse(textBoxIP.Text);
            int port = int.Parse("9999");
            server = new TcpListener(ipAddress, port);
            server.Start();
            AddMess("Server running on port 9999");
            Task.Run(() => Listen());
            buttonListen.Enabled = false;
            buttonListen.Text = "Listening...";
            buttonListen.BackColor = Color.Lime;
        }
        private void Listen()
        {
            while (true)
            {
                client = server.AcceptTcpClient();
                Task.Run(() => Receive(client));
            }
        }
        private void Receive(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;
            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    BroadcastMessage(FindIPAddress(message), client);
                    this.Invoke((MethodInvoker)delegate
                    {
                        AddMess(message);
                    });
                }
                catch
                {
                    break;
                }
            }
        }
        private void BroadcastMessage(string message, TcpClient sender)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(buffer, 0, buffer.Length);
        }
        string FindIPAddress(string s)
        {
            foreach (DNS dNS in dns)
            {
                if (dNS.hostname == s)
                    return dNS.IP;
            }
            return "Not found";
        }
        public void AddMess(string mess)
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm:ss");
            listBoxMess.Items.Add(formattedTime + ": " + mess);
        }
        private void textBoxIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonListen.PerformClick();
            }
        }
    }
}
