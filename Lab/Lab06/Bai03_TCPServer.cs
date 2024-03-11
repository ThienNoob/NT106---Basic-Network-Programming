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
using System.Security.Cryptography;

namespace Lab06
{
    public partial class Bai03_TCPServer : Form
    {
        public Bai03_TCPServer()
        {
            InitializeComponent();
            buttonListen.Select();
        }
        TcpListener server = null;
        List<TcpClient> clients = new List<TcpClient>();
        private static readonly byte[] key = Encoding.UTF8.GetBytes("16byteEncryption"); // Key có độ dài 16 byte (128-bit)
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("16byteIVVectorrr"); // IV có độ dài 16 byte (128-bit)
        private static byte[] EncryptAes(string plaintext, byte[] key, byte[] iv)
        {
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }
        private static string DecryptAes(byte[] ciphertext, byte[] key, byte[] iv)
        {
            string plaintext;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(ciphertext))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
        private void buttonListen_Click(object sender, EventArgs e)
        {
            if (buttonListen.BackColor == Color.Aquamarine)
            {
                try
                {
                    IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                    int port = int.Parse("8080");
                    server = new TcpListener(ipAddress, port);
                    server.Start();
                    richTextBoxScreen.Text += "Server running on 127.0.0.1:8080";
                    Task.Run(() => Listen());
                    // update status
                    buttonListen.BackColor = Color.Lime;
                    buttonListen.Text = "Listening...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    clients.Add(client);
                    Task.Run(() => Receive(client));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string receiveData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    byte[] encryptedData = EncryptAes(receiveData, key, iv);
                    textBoxEncriptedMsg.Text = string.Empty;
                    textBoxEncriptedMsg.Text = Encoding.UTF8.GetString(encryptedData);
                    string decriptedData = DecryptAes(encryptedData, key, iv);

                    string message = decriptedData;

                    if (message.Contains("New client"))
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            richTextBoxScreen.Text += message;
                            listBoxMembers.Items.Add(message.Replace("New client connected: ", ""));
                        });
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
        private void Bai05_TCPServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (buttonListen.BackColor == Color.Lime)
                {
                    BroadcastMessage("Server disconnected!", null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}