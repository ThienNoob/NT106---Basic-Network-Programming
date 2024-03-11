namespace Lab2
{
    partial class fBaif5
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnNen = new System.Windows.Forms.Button();
            this.btnGiaiNen = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(464, 410);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnNen
            // 
            this.btnNen.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNen.Location = new System.Drawing.Point(527, 12);
            this.btnNen.Name = "btnNen";
            this.btnNen.Size = new System.Drawing.Size(239, 105);
            this.btnNen.TabIndex = 1;
            this.btnNen.Text = "NÉN";
            this.btnNen.UseVisualStyleBackColor = true;
            this.btnNen.Click += new System.EventHandler(this.btnNen_Click);
            // 
            // btnGiaiNen
            // 
            this.btnGiaiNen.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGiaiNen.Location = new System.Drawing.Point(527, 163);
            this.btnGiaiNen.Name = "btnGiaiNen";
            this.btnGiaiNen.Size = new System.Drawing.Size(239, 105);
            this.btnGiaiNen.TabIndex = 1;
            this.btnGiaiNen.Text = "GIẢI NÉN";
            this.btnGiaiNen.UseVisualStyleBackColor = true;
            this.btnGiaiNen.Click += new System.EventHandler(this.btnGiaiNen_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDoc.Location = new System.Drawing.Point(527, 317);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(239, 105);
            this.btnDoc.TabIndex = 1;
            this.btnDoc.Text = "ĐỌC";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // fBaif5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnGiaiNen);
            this.Controls.Add(this.btnNen);
            this.Controls.Add(this.richTextBox1);
            this.Name = "fBaif5";
            this.Text = "Bài 05 – Nén dữ liệu trong file";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnNen;
        private Button btnGiaiNen;
        private Button btnDoc;
    }
}