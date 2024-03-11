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

namespace Lab05
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
            textBoxMatKhau.UseSystemPasswordChar = true;
        }
        public void load()
        {
            dataGridView1.Rows.Clear();
            var imapClient = new ImapClient();
            imapClient.Connect("imap.gmail.com", 993, true);
            imapClient.Authenticate(textBoxTaiKhoan.Text, textBoxMatKhau.Text);
            var imapInbox = imapClient.Inbox;
            imapInbox.Open(FolderAccess.ReadOnly);
            int stt = 1;
            // đọc 10 thư mới nhất
            for (int i = imapInbox.Count - 1; i >= imapInbox.Count - 1 - 10; i--)
            {
                var mess = imapInbox.GetMessage(i);
                string[] row = { stt++.ToString(), mess.From[0].ToString(), mess.Subject, mess.Date.LocalDateTime.ToString(), mess.TextBody };
                dataGridView1.Rows.Add(row);
            }
            imapClient.Disconnect(true);
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            load();
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            load();
            buttonLogIn.Visible = false;
            dataGridView1.Visible = true;
            buttonSend.Visible = true;
            buttonRefresh.Visible = true;
            buttonLogOut.Visible = true;
            groupBoxCaiDat.Enabled = false;
            textBoxTaiKhoan.Enabled = false;
            textBoxMatKhau.Enabled = false;
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            buttonLogIn.Visible = true;
            dataGridView1.Visible = false;
            buttonSend.Visible = false;
            buttonRefresh.Visible = false;
            buttonLogOut.Visible = false;
            groupBoxCaiDat.Enabled = true;
            textBoxTaiKhoan.Enabled = true;
            textBoxMatKhau.Enabled = true;
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendMail formSendMail = new SendMail("", "flag");
            formSendMail.Show();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView1.Rows.Count)
            {
                DataGridViewRow selected = dataGridView1.Rows[index];
                string subject = selected.Cells["Subject"].Value.ToString();
                string from = selected.Cells["From"].Value.ToString();
                string to = textBoxTaiKhoan.Text;
                string body = selected.Cells["Body"].Value.ToString();
                ShowMail formShowMail = new ShowMail(subject, from, to, body);
                formShowMail.ShowDialog();
            }
        }
    }
}
