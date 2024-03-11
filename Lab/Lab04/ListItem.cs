using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        private string title;
        [Category("Custom Properties")]
        public string Title
        {
            get { return title; }
            set { title = value; Names.Text = value; }
        }
        private Image icon;
        [Category("Custom Properties")]

        public Image Icon
        {
            get { return icon; }
            set { icon = value; pictureBox1.Image = value; }
        }
        private string message;
        [Category("Custom Properties")]

        public string Message
        {
            get { return message; }
            set { message = value; Info.Text = value; }
        }
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler NameClick;
        private void Names_Click(object sender, EventArgs e)
        {
            NameClick?.Invoke(sender, e);
        }
    }
}
