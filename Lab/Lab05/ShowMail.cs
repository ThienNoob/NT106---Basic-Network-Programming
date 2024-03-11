using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab05
{
    public partial class ShowMail : Form
    {
        public ShowMail(string subject, string from, string to, string body)
        {
            InitializeComponent();
            this.Text = subject;
            labelFrom.Text = from;
            labelTo.Text = to;
            richTextBoxBody.Text = body;
        }
        private void buttonReply_Click(object sender, EventArgs e)
        {
            string from = labelFrom.Text;
            string to = labelTo.Text;
            string pattern = @"<([^>]+)>";
            Match match = Regex.Match(from, pattern);
            string getFrom = "";
            if (match.Success)
            {
                getFrom = match.Groups[1].Value;
            }
            SendMail formSendMail = new SendMail(getFrom, to);
            formSendMail.Show();
        }
    }
}
