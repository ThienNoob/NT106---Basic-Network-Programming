using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            try
            {
                char[] chars = txtInput.Text.ToCharArray();
                char[] mahoa = new char[chars.Length];
                for (int i = 0; i < chars.Length; i++)
                {
                    mahoa[i] = (char)((int)(chars[i]) + int.Parse(txtShift.Text));
                }

                txtMaHoa.Text = new string(mahoa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập Shift là số !");
            }
        }
        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            char[] mahoa = txtMaHoa.Text.ToCharArray();
            char[] giaima = new char[mahoa.Length];
            for (int i = 0; i < mahoa.Length; i++)
            {
                giaima[i] = (char)((int)(mahoa[i]) - int.Parse(txtShift.Text));
            }
            txtGiaiMa.Text = new string(giaima);
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            btnMaHoa.PerformClick();
            txtGiaiMa.Text = "";
        }
        private void txtShift_TextChanged(object sender, EventArgs e)
        {
            btnMaHoa.PerformClick();
            txtGiaiMa.Text = "";
        }
    }
}
