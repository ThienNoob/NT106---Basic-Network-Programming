namespace Lab2
{
    partial class fBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txSize = new System.Windows.Forms.Label();
            this.txURL = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.tbWords = new System.Windows.Forms.TextBox();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(383, 29);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read from File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(383, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(401, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 425);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name";
            // 
            // txSize
            // 
            this.txSize.AutoSize = true;
            this.txSize.Location = new System.Drawing.Point(12, 128);
            this.txSize.Name = "txSize";
            this.txSize.Size = new System.Drawing.Size(36, 20);
            this.txSize.TabIndex = 2;
            this.txSize.Text = "Size";
            // 
            // txURL
            // 
            this.txURL.AutoSize = true;
            this.txURL.Location = new System.Drawing.Point(12, 187);
            this.txURL.Name = "txURL";
            this.txURL.Size = new System.Drawing.Size(35, 20);
            this.txURL.TabIndex = 2;
            this.txURL.Text = "URL";
            // 
            // tb
            // 
            this.tb.AutoSize = true;
            this.tb.Location = new System.Drawing.Point(12, 241);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(77, 20);
            this.tb.TabIndex = 2;
            this.tb.Text = "Line count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Words count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Character count";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(139, 74);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(256, 27);
            this.tbFileName.TabIndex = 1;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(139, 121);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(256, 27);
            this.tbSize.TabIndex = 2;
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(139, 187);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(256, 27);
            this.tbURL.TabIndex = 3;
            // 
            // tbLine
            // 
            this.tbLine.Location = new System.Drawing.Point(139, 234);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(256, 27);
            this.tbLine.TabIndex = 4;
            // 
            // tbWords
            // 
            this.tbWords.Location = new System.Drawing.Point(139, 296);
            this.tbWords.Name = "tbWords";
            this.tbWords.Size = new System.Drawing.Size(256, 27);
            this.tbWords.TabIndex = 5;
            // 
            // tbChar
            // 
            this.tbChar.Location = new System.Drawing.Point(139, 343);
            this.tbChar.Name = "tbChar";
            this.tbChar.Size = new System.Drawing.Size(256, 27);
            this.tbChar.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbChar);
            this.Controls.Add(this.tbLine);
            this.Controls.Add(this.tbWords);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.txURL);
            this.Controls.Add(this.txSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRead);
            this.Name = "fBai2";
            this.Text = "Bài 02 – Đọc thông tin một file .txt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRead;
        private Button btnExit;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label txSize;
        private Label txURL;
        private Label tb;
        private Label label5;
        private Label label6;
        private TextBox tbFileName;
        private TextBox tbSize;
        private TextBox tbURL;
        private TextBox tbLine;
        private TextBox tbWords;
        private TextBox tbChar;
        private OpenFileDialog openFileDialog1;
    }
}