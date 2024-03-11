namespace Lab04
{
    partial class Bai02
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.rtbXuat = new System.Windows.Forms.RichTextBox();
            this.btPOST = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbURL.Location = new System.Drawing.Point(12, 12);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(636, 27);
            this.tbURL.TabIndex = 1;
            this.tbURL.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbData.Location = new System.Drawing.Point(12, 70);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(636, 27);
            this.tbData.TabIndex = 0;
            // 
            // rtbXuat
            // 
            this.rtbXuat.Location = new System.Drawing.Point(12, 120);
            this.rtbXuat.Name = "rtbXuat";
            this.rtbXuat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbXuat.Size = new System.Drawing.Size(757, 456);
            this.rtbXuat.TabIndex = 3;
            this.rtbXuat.Text = "";
            // 
            // btPOST
            // 
            this.btPOST.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPOST.Location = new System.Drawing.Point(654, 12);
            this.btPOST.Name = "btPOST";
            this.btPOST.Size = new System.Drawing.Size(116, 27);
            this.btPOST.TabIndex = 2;
            this.btPOST.Text = "POST";
            this.btPOST.UseVisualStyleBackColor = true;
            this.btPOST.Click += new System.EventHandler(this.btPOST_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // Bai02
            // 
            this.AcceptButton = this.btPOST;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPOST);
            this.Controls.Add(this.rtbXuat);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbURL);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbURL;
        private TextBox tbData;
        private RichTextBox rtbXuat;
        private Button btPOST;
        private Label label1;
    }
}