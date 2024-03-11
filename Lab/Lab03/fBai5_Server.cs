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
namespace Lab3
{
    public partial class fBai5_Server : Form
    {
        public fBai5_Server()
        {
            InitializeComponent();
        }
        TcpListener server = null;
        List<TcpClient> clients = new List<TcpClient>();

        private void btnListen_Click(object sender, EventArgs e)
        {
            
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = int.Parse("9999");
            server = new TcpListener(ipAddress, port);
            server.Start();
            rtxtMess.Text += "Server running on 127.0.0.1: 9999";
            Task.Run(() => Listen());
            btnListen.Enabled = false;

        }
        private void Listen()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                clients.Add(client);
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
                    
                    if (message.Contains("New client connected from: 127.0.0.1"))
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            rtxtMess.Text += message;
                        });
                    }
                    else
                    {
                        BroadcastMessage(message, client);                     
                        this.Invoke((MethodInvoker)delegate {
                            rtxtMess.Text += "\n" + message;
                        });
                    }
                }
                catch
                {                 
                    clients.Remove(client);
                    break;
                }
            }
        }

        private void BroadcastMessage(string message, TcpClient sender)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);

            foreach (TcpClient client in clients)
            {
                if (client != sender)
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
        private void fBai3_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close();
        }
    }
}
