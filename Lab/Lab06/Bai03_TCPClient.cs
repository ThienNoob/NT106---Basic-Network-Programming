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
    public partial class Bai03_TCPClient : Form
    {
        public Bai03_TCPClient()
        {
            InitializeComponent();
            textBoxYourName.Focus();
        }
        TcpClient client = new TcpClient();
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
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (textBoxYourName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Invalid name! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxYourName.Focus();
                textBoxYourName.Text = string.Empty;
            }
            else
            {
                if (buttonConnect.Text == "Connect")
                {
                    try
                    {
                        string serverIP = "127.0.0.1";
                        int serverPort = int.Parse("8080");
                        client = new TcpClient(serverIP, serverPort);
                        Task.Run(() => Listen());
                        string message = "\nNew client connected: " + textBoxYourName.Text;
                        byte[] buffer = Encoding.UTF8.GetBytes(message);
                        NetworkStream stream = client.GetStream();

                        byte[] encryptedData = EncryptAes(message, key, iv);
                        textBoxEncriptedMsg.Text = string.Empty;
                        textBoxEncriptedMsg.Text = Encoding.UTF8.GetString(encryptedData);
                        string decriptedData = DecryptAes(encryptedData, key, iv);
                        byte[] sendData = Encoding.UTF8.GetBytes(decriptedData);

                        stream.Write(sendData, 0, sendData.Length);
                        // update status
                        textBoxMessage.Enabled = true;
                        buttonSend.Enabled = true;
                        textBoxYourName.Enabled = false;
                        buttonConnect.Text = "Disconnect";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    SendMessage(textBoxYourName.Text + " has left the chat.");
                    client.Close();
                    // update status
                    textBoxMessage.Enabled = false;
                    buttonSend.Enabled = false;
                    textBoxYourName.Enabled = true;
                    buttonConnect.Text = "Connect";
                }
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string message = textBoxYourName.Text + ": " + textBoxMessage.Text;
            SendMessage(message);
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
                        textBoxYourName.Enabled = true;
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
            NetworkStream stream = client.GetStream();
            byte[] encryptedData = EncryptAes(message, key, iv);
            textBoxEncriptedMsg.Text = string.Empty;
            textBoxEncriptedMsg.Text = Encoding.UTF8.GetString(encryptedData);
            string decriptedData = DecryptAes(encryptedData, key, iv);
            byte[] sendData = Encoding.UTF8.GetBytes(decriptedData);
            
            stream.Write(sendData, 0, sendData.Length);
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

        private void Bai03_TCPClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (buttonConnect.Text == "Disconnect")
            {
                SendMessage(textBoxYourName.Text + " has left the chat.");
                client.Close();
            }
        }

        private void textBoxYourName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonConnect.PerformClick();
            }
        }
    }
}