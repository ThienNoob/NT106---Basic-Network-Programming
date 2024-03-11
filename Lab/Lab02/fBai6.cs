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

namespace Lab2
{
    public partial class fBai6 : Form
    {
        public fBai6()
        {
            InitializeComponent();
        }

        private void fBai6_Load(object sender, EventArgs e)
        {
            InitTree();
        }

        private void InitTree()
        {
            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach(string drv in drives)
            {
                node= new TreeNode(drv);
                treeView1.Nodes.Add(node);
                node.Nodes.Add("...");
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            try
            {
                foreach (string dir in Directory.GetDirectories(node.FullPath))
                {
                    TreeNode n = node.Nodes.Add(Path.GetFileName(dir));
                    n.Nodes.Add("...");
                }
            }
            catch
            {
                 
            }
        }

        private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                
                string[] arrFile = Directory.GetFiles(e.Node.FullPath);
                flowLayoutPanel1.Controls.Clear();
                foreach (string file in arrFile)
                {
                    if (file.ToLower().EndsWith(".jpg") ||
                        file.ToLower().EndsWith(".gif") ||
                        file.ToLower().EndsWith(".png") ||
                        file.ToLower().EndsWith(".bmp") ||
                        file.ToLower().EndsWith(".jpeg"))
                    {
                        Button btnPic = new Button();
                        btnPic.Text = file;
                        btnPic.AutoSize = true;
                        flowLayoutPanel1.Controls.Add(btnPic);
                        btnPic.Click += new EventHandler(btnPic_Click);

                    }
                    else if (file.ToLower().EndsWith(".txt"))

                    {
                        Button btnText = new Button();
                        btnText.AutoSize = true;
                        btnText.Text = file;
                        flowLayoutPanel1.Controls.Add(btnText);
                        btnText.Click += new EventHandler(btnText_Click);
                    }

                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            
        }

        private void btnPic_Click(object sendder,EventArgs e)
        {

            Button btnPic = (Button)sendder;
            panel1.Controls.Clear();
            PictureBox pic = new PictureBox();
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image=Image.FromFile(btnPic.Text);
            pic.Size = panel1.Size;
            panel1.Controls.Add(pic);

            
        }
        private void btnText_Click(object sendder, EventArgs e)
        {

            Button btnText = (Button)sendder;
            panel1.Controls.Clear();
            RichTextBox text = new RichTextBox();
            text.Size = panel1.Size;
            FileStream fs = new FileStream(btnText.Text, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            text.Text = sr.ReadToEnd();
            fs.Close();
            panel1.Controls.Add(text);


        }
    }
}
