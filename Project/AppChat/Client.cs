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

namespace AppChat
{
    public partial class Client : Form
    {
        TcpClient client = new TcpClient();
        public Client()
        {
            InitializeComponent();
            buttonConnect.Select();
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Connect")
            {
                try
                {
                    string serverIP = "127.0.0.1";
                    int serverPort = int.Parse("9999");
                    client = new TcpClient(serverIP, serverPort);
                    Task.Run(() => Listen());
                    string message = "\nNew member connected: " + labelName.Text;
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    NetworkStream stream = client.GetStream();
                    stream.Write(buffer, 0, buffer.Length);
                    // update status
                    textBoxMessage.Enabled = true;
                    buttonSend.Enabled = true;
                    textBoxStatus.BackColor = Color.Lime;
                    labelStatus.Text = "Online";
                    labelStatus.ForeColor = Color.Lime;
                    buttonConnect.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    Message msg = new Message();
                    msg.labelCaption.Text = "Error";
                    msg.bunifuLabelText.Text = "Failed to connect to server: " + ex.Message;
                    msg.ShowDialog();
                }
            }
            else
            {
                SendMessage(labelName.Text + " has left the chat.");
                client.Close();
                // update status
                textBoxMessage.Enabled = false;
                buttonSend.Enabled = false;
                textBoxStatus.BackColor = Color.Red;
                labelStatus.Text = "Offline";
                labelStatus.ForeColor = Color.Red;
                buttonConnect.Text = "Connect";
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == "restart")
            {
                Confirm formConfirm = new Confirm();
                formConfirm.ShowDialog();
                if (formConfirm.check == 1)
                {
                    Message msg = new Message();
                    msg.labelCaption.Text = "Warning";
                    msg.bunifuLabelText.Text = "Server will be restarted.";
                    msg.ShowDialog();
                    Server formServer = new Server();
                    formServer.Show();
                    string message = textBoxMessage.Text;
                    SendMessage(message);
                    // update status
                    textBoxMessage.Enabled = false;
                    buttonSend.Enabled = false;
                    textBoxStatus.BackColor = Color.Red;
                    labelStatus.Text = "Offline";
                    labelStatus.ForeColor = Color.Red;
                    buttonConnect.Text = "Connect";
                }
            }
            else if (textBoxMessage.Text == "shutdown")
            {
                Confirm formConfirm = new Confirm();
                formConfirm.ShowDialog();
                if (formConfirm.check == 1)
                {
                    string message = textBoxMessage.Text;
                    SendMessage(message);
                    textBoxMessage.Enabled = false;
                    buttonSend.Enabled = false;
                    textBoxStatus.BackColor = Color.Red;
                    labelStatus.Text = "Offline";
                    labelStatus.ForeColor = Color.Red;
                    buttonConnect.Text = "Connect";
                }
            }
            else
            {
                string message = labelName.Text + ": " + textBoxMessage.Text;
                SendMessage(message);
            }
        }
        private void Listen()
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
                    if (message.Contains("Server disconnected!"))
                    {
                        textBoxMessage.Enabled = false;
                        buttonSend.Enabled = false;
                        textBoxStatus.BackColor = Color.Red;
                        labelStatus.Text = "Offline";
                        labelStatus.ForeColor = Color.Red;
                        buttonConnect.Text = "Connect";
                    }
                    AddMessage(message);
                }
                catch
                {
                    client.Close();
                    break;
                }
            }
        }
        void SendMessage(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(buffer, 0, buffer.Length);
            richTextBoxScreen.Text += message + "\n";
            textBoxMessage.Text = string.Empty;
        }
        private void AddMessage(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AddMessage(s)));
                return;
            }
            richTextBoxScreen.Text += s + "\n";
        }
        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBoxMessage.Text.Contains("\n"))
                textBoxMessage.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                buttonSend.PerformClick();
            }
        }
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (buttonConnect.Text == "Disconnect")
            {
                SendMessage(labelName.Text + " has left the chat.");
                client.Close();
            }
        }
    }
}