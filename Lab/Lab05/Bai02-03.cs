using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Search;
using MimeKit;

namespace Lab05
{
    public partial class Bai02_03 : Form
    {
        public Bai02_03()
        {
            InitializeComponent();
            textBoxEmail.Focus();
            textBoxEmail.SelectAll();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                if (comboBoxProtocol.Text.Contains("POP3"))
                {
                    Pop3Client popClient = new Pop3Client();
                    popClient.Connect("pop.gmail.com", 995, true);
                    popClient.Authenticate(textBoxEmail.Text, textBoxPassword.Text);
                    int totalEmailReceived = popClient.GetMessageCount();
                    labelTotal.Text = totalEmailReceived.ToString();
                    label4.Visible = false;
                    labelRecent.Visible = false;
                    // lấy 10 thư mới nhất để đọc
                    for (int i = totalEmailReceived - 1; i >= totalEmailReceived - 1 - 10; i--)
                    {
                        var mess = popClient.GetMessage(i);
                        string[] row = { mess.Subject, mess.From[0].ToString(), mess.Date.LocalDateTime.ToString() };
                        ListViewItem temp = new(row);
                        listView1.Items.Add(temp);
                    }
                }
                if (comboBoxProtocol.Text.Contains("IMAP"))
                {
                    ImapClient imapClient = new ImapClient();
                    imapClient.Connect("imap.gmail.com", 993, true);
                    imapClient.Authenticate(textBoxEmail.Text, textBoxPassword.Text);
                    var imapInbox = imapClient.Inbox;
                    imapInbox.Open(FolderAccess.ReadOnly);
                    labelTotal.Text = imapInbox.Count.ToString();
                    var unreadMessages = imapInbox.Search(SearchOptions.All, SearchQuery.NotSeen);
                    label4.Visible = true;
                    labelRecent.Visible = true;
                    labelRecent.Text = unreadMessages.Count.ToString();
                    // lấy 10 thư mới nhất để đọc
                    for (int i = imapInbox.Count - 1; i >= imapInbox.Count - 1 - 10; i--)
                    {
                        var mess = imapInbox.GetMessage(i);
                        string[] row = { mess.Subject, mess.From[0].ToString(), mess.Date.LocalDateTime.ToString() };
                        ListViewItem temp = new(row);
                        listView1.Items.Add(temp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
                textBoxPassword.SelectAll();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
