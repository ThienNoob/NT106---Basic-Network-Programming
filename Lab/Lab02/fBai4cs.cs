using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2
{
    public partial class fBai4cs : Form
    {
        public fBai4cs()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Phone { get; set; }
            public float Course1 { get; set; }
            public float Course2 { get; set; }
            public float Course3 { get; set; }
            public float Aver { get; set; }



        }
        public string ConvertToString(Student s)
        {
            return $"{s.Name}\n{s.ID}\n{s.Phone}\n{s.Course1}\n{s.Course2}\n{s.Course3}\n{s.Aver}";
        }
        public List<Student> students = new List<Student>();
        public int check() // hàm kiểm tra điều kiện nhập vào
        {
            string str = tbPhoenI.Text;
            if (str.Length != 10 || str[0] != '0')
                return 0;
            if (float.Parse(tbC1I.Text) > 10 || float.Parse(tbC1I.Text) < 0)
                return 0;
            if (float.Parse(tbC2I.Text) > 10 || float.Parse(tbC1I.Text) < 0)
                return 0;
            if (float.Parse(tbC3I.Text) > 10 || float.Parse(tbC1I.Text) < 0)
                return 0;
            str = tbIDI.Text;
            if (str.Length != 8)
                return 0;
            return 1;

        }


        private void button1_Click(object sender, EventArgs e) //ADD
        {
            if (check()==1)
            { 
                     
                string Name = tbNameI.Text;
                int ID = int.Parse(tbIDI.Text);
                string Phone = tbPhoenI.Text;
                float Course1 = float.Parse(string.Format("{0:0.##}", tbC1I.Text));
                float Course2 = float.Parse(string.Format("{0:0.##}", tbC2I.Text));
                float Course3 = float.Parse(string.Format("{0:0.##}", tbC3I.Text));
                Student s = new Student();
                s.Name = Name;
                s.ID = ID;
                s.Phone = Phone;
                s.Course1 = Course1;
                s.Course2 = Course2;
                s.Course3 = Course3;
                students.Add(s);
                MessageBox.Show("Đã thêm thông tin !");
                tbNameI.Text = "";
                tbIDI.Text = "";
                tbPhoenI.Text = "";
                tbC1I.Text = "";
                tbC2I.Text = "";
                tbC3I.Text = "";
                tbAveI.Text = "";
            }
            else
                MessageBox.Show("Nhập thông tin không đúng format !");

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            using (Stream s = File.Open("input4.txt", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(s, students);
            }
            using (StreamWriter sw = new StreamWriter("output4.txt"))
            {
                foreach (Student st in students)
                {
                    st.Aver = float.Parse(string.Format("{0:0.##}", (st.Course1 + st.Course2 + st.Course3) / 3)); 
                    sw.WriteLine(ConvertToString(st));
                    
                }
            }
            richTextBox1.Text = "";

            foreach (Student st in students)
            {
                richTextBox1.Text += ConvertToString(st) + "\n\r";
            }

            MessageBox.Show("Đã ghi dữ liệu vào file ! ");
        }

           
       
        private void btnRead_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.Open("input4.txt", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                students = (List<Student>)formatter.Deserialize(stream);
            }
            foreach (Student st in students)
            {
                st.Aver = (st.Course1 + st.Course2 + st.Course3) / 3;
            }    
            
            Student s = students[0];
            tbNameO.Text = s.Name;
            tbIDO.Text = s.ID + "";
            tbPhone.Text = s.Phone;
            tbC1O.Text = string.Format("{0:0.##}", s.Course1);
            tbC2O.Text = string.Format("{0:0.##}", s.Course2);
            tbC3O.Text = string.Format("{0:0.##}", s.Course3);
            tbAverO.Text = string.Format("{0:0.##}", s.Aver);
            label.Text = 0 + "";



        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i= int.Parse(label.Text);
            if (i == students.Count-1)
                i = 0;
            else i++;
            Student s = students[i];
            tbNameO.Text = s.Name;
            tbIDO.Text = s.ID + "";
            tbPhone.Text = s.Phone;
            tbC1O.Text = string.Format("{0:0.##}", s.Course1);
            tbC2O.Text = string.Format("{0:0.##}", s.Course2);
            tbC3O.Text = string.Format("{0:0.##}", s.Course3);
            tbAverO.Text = string.Format("{0:0.##}", s.Aver);
            label.Text = i + "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int i = int.Parse(label.Text);
            if (i == 0)
                i = students.Count-1;
            else i--;
            Student s = students[i];
            tbNameO.Text = s.Name;
            tbIDO.Text = s.ID + "";
            tbPhone.Text = s.Phone;
            tbC1O.Text = string.Format("{0:0.##}", s.Course1);
            tbC2O.Text = string.Format("{0:0.##}", s.Course2);
            tbC3O.Text = string.Format("{0:0.##}", s.Course3);
            tbAverO.Text = string.Format("{0:0.##}", s.Aver);
            label.Text = i + "";
        }
    }
}
