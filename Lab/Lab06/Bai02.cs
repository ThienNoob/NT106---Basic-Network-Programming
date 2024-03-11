using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
            Matrix = CreatMatrix();
        }
        public string Key;
        public char[,] Matrix;
        public string CreateKey(string key, string input)
        {
            char[] keyArr = new char[32];
            keyArr = key.ToCharArray();
            char[] inputArr = input.ToCharArray();
            char[] returnKey = new char[32];
            if (key.Length > input.Length)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    returnKey[i] = keyArr[i];
                }
                return new string(returnKey);
            }

            for (int i = 0; i < key.Length; i++)
            {
                returnKey[i] = keyArr[i];
            }
            int j = 0;
            for (int i = keyArr.Length; i < inputArr.Length; i++)
            {
                returnKey[i] = inputArr[j];
                j++;
            }
            return new string(returnKey);
        }
        private void btnGiaiMa_Click_1(object sender, EventArgs e)
        {
            char[] dataArr = txtMaHoa.Text.ToCharArray();
            char[] keyArr = txtKey.Text.ToCharArray();
            for (int i = 0; i < dataArr.Length; i++)
            {
                txtGiaiMa.Text += (char)(FindIndex(keyArr[i], dataArr[i]) + 65);
            }
        }
        private void btnMaHoa_Click_1(object sender, EventArgs e)
        {
            txtMaHoa.Text = "";
            try
            {
                txtInput.Text = txtInput.Text.ToUpper();
                txtKey.Text = txtKey.Text.ToUpper();
                txtKey.Text = CreateKey(txtKey.Text, txtInput.Text);

                char[] inputArr = txtInput.Text.ToCharArray();
                char[] keyArr = txtKey.Text.ToCharArray();
                for (int i = 0; i < inputArr.Length; i++)
                {
                    int j = (int)inputArr[i] - 65;
                    int k = (int)keyArr[i] - 65;
                    txtMaHoa.Text += Matrix[j, k] + "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Only accept charater A-Z, please check then try again!");
                txtMaHoa.Text = "";
            }
        }
        public static char[,] CreatMatrix()
        {
            char[,] Matrix = new char[26, 26];

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    char c = (char)((i + j) % 26 + 65);

                    Matrix[i, j] = c;

                }
            }
            return Matrix;
        }
        public int FindIndex(char key, char data)
        {
            for (int i=0;i<26;i++)
            {
                if (Matrix[i, (int)key - 65] == data)
                    return i;
            }
            return -1;
        }
        private void txtKey_TextChanged_1(object sender, EventArgs e)
        {
            txtMaHoa.Text = "";
            txtGiaiMa.Text = "";
        }
        private void txtInput_TextChanged_1(object sender, EventArgs e)
        {
            txtMaHoa.Text = "";
            txtGiaiMa.Text = "";
        }
    }
}
