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

namespace AppChat
{
    public partial class Server : Form
    {
        TcpListener server = null;
        List<TcpClient> clients = new List<TcpClient>();
        public Server()
        {
            InitializeComponent();
            buttonListen.Select();
        }
        private void buttonListen_Click(object sender, EventArgs e)
        {
            if (buttonListen.BackColor == Color.Fuchsia)
            {
                try
                {
                    IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                    int port = int.Parse("9999");
                    server = new TcpListener(ipAddress, port);
                    server.Start();
                    richTextBoxScreen.Text += "Server running on 127.0.0.1: 9999";
                    Task.Run(() => Listen());
                    // update status
                    buttonListen.BackColor = Color.Lime;
                    buttonListen.Text = "Listening...";
                }
                catch (Exception ex)
                {
                    Message msg = new Message();
                    msg.labelCaption.Text = "Error";
                    msg.bunifuLabelText.Text = ex.Message;
                    msg.ShowDialog();
                }
            }
            else if (buttonListen.BackColor == Color.Lime)
            {
                buttonListen.BackColor = Color.Red;
                buttonListen.Text = "Listen";
                BroadcastMessage("Server disconnected!", null);
                listBoxMembers.Items.Clear();
                server.Stop();
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
            while (true)
            {
                try
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (message.Contains("New member"))
                    {
                        this.Invoke((MethodInvoker) delegate
                        {
                            richTextBoxScreen.Text += message;
                            listBoxMembers.Items.Add(message.Replace("New member connected: ", ""));
                        });
                    }
                    else if (message == "shutdown")
                    {
                        Message msg = new Message();
                        msg.labelCaption.Text = "Warning";
                        msg.bunifuLabelText.Text = "Server will be shut down.";
                        msg.ShowDialog();
                        Thread.Sleep(500);
                        server.Stop();
                        Close();
                    }
                    else if ((message == "restart"))
                    {
                        server.Stop();
                        Close();
                    }
                    else if (message.Contains("has left the chat."))
                    {
                        for (int i = listBoxMembers.Items.Count - 1; i >= 0; i--)
                        {
                            string item = listBoxMembers.Items[i].ToString();
                            if (item.Contains(message.Replace(" has left the chat.", "")))
                            {
                                listBoxMembers.Items.RemoveAt(i);
                            }
                        }
                        BroadcastMessage(message, client);
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxScreen.Text += "\n" + message;
                        });
                    }
                    else
                    {
                        BroadcastMessage(message, client);
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxScreen.Text += "\n" + message;
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
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (buttonListen.BackColor == Color.Lime)
                {
                    BroadcastMessage("Server disconnected!", null);
                    server.Stop();
                }
            }
            catch (Exception ex) 
            {
                Message msg = new Message();
                msg.labelCaption.Text = "Error";
                msg.bunifuLabelText.Text = ex.Message;
                msg.ShowDialog();
            }
        }
    }
}