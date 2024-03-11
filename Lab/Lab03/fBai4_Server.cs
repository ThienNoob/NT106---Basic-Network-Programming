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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3
{
    public partial class fBai4_Server : Form
    {
        public fBai4_Server()
        {
            InitializeComponent();
            btnListen.BringToFront();
        }
        TcpListener server = null;
        List<TcpClient> clients = new List<TcpClient>();


        private void btnListen_Click(object sender, EventArgs e)
        {
            if (btnListen.BackColor == Color.Red)
            {
                try
                {
                    IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                    int port = int.Parse("9999");
                    server = new TcpListener(ipAddress, port);
                    server.Start();
                    rtxtMess.Text += "\nServer running on 127.0.0.1: 9999";
                    Task.Run(() => Listen());
                    btnListen.BackColor = Color.Lime;
                    btnListen.FlatAppearance.BorderColor = Color.LightGreen;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }

            else if (btnListen.BackColor == Color.Lime)
            {
                btnListen.BackColor = Color.Red;
                btnListen.FlatAppearance.BorderColor = Color.PaleVioletRed;
                BroadcastMessage("Server disconnected", null);
                server.Stop();

            }

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

                    if (message.Contains("New member"))
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            rtxtMess.Text += message;
                            lboxMember.Items.Add(message.Replace("New member - ", ""));
                        });
                    }

                    else if (message.Contains("has left the chat"))
                    {
                        for (int i = lboxMember.Items.Count - 1; i >= 0; i--)
                        {
                            string item = lboxMember.Items[i].ToString();
                            if (item.Contains(message.Replace(" has left the chat", "")))
                            {
                                lboxMember.Items.RemoveAt(i);
                            }
                        }
                        BroadcastMessage(message, client);
                        this.Invoke((MethodInvoker)delegate
                        {
                            rtxtMess.Text += "\n" + message;
                        });

                    }


                    else
                    {
                        BroadcastMessage(message, client);
                        this.Invoke((MethodInvoker)delegate
                        {
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
            try
            {
                if (btnListen.BackColor == Color.Lime)
                {
                    BroadcastMessage("Server disconnected", null);
                    server.Stop();
                    if (lboxMember.Items.Count > 0 && Text == "Server")
                    {
                        fBai4_Server fServer2 = new fBai4_Server();
                        fServer2.Show();
                        fServer2.Text = "Server 2";
                        fServer2.btnListen.PerformClick();
                    }



                }
            }
            catch (Exception ex)
            {

            }
        }

        private void fServer_Load(object sender, EventArgs e)
        {

        }
    }
}
