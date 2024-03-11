namespace Lab05
{
    partial class MainForm
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
            this.buttonBai1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBai2_3 = new System.Windows.Forms.Button();
            this.buttonBai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBai1
            // 
            this.buttonBai1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBai1.Location = new System.Drawing.Point(58, 165);
            this.buttonBai1.Name = "buttonBai1";
            this.buttonBai1.Size = new System.Drawing.Size(102, 55);
            this.buttonBai1.TabIndex = 0;
            this.buttonBai1.Text = "Bài 1";
            this.buttonBai1.UseVisualStyleBackColor = true;
            this.buttonBai1.Click += new System.EventHandler(this.buttonBai1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // buttonBai2_3
            // 
            this.buttonBai2_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBai2_3.Location = new System.Drawing.Point(220, 165);
            this.buttonBai2_3.Name = "buttonBai2_3";
            this.buttonBai2_3.Size = new System.Drawing.Size(102, 55);
            this.buttonBai2_3.TabIndex = 1;
            this.buttonBai2_3.Text = "Bài 2+3";
            this.buttonBai2_3.UseVisualStyleBackColor = true;
            this.buttonBai2_3.Click += new System.EventHandler(this.buttonBai2_3_Click);
            // 
            // buttonBai4
            // 
            this.buttonBai4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBai4.Location = new System.Drawing.Point(382, 165);
            this.buttonBai4.Name = "buttonBai4";
            this.buttonBai4.Size = new System.Drawing.Size(102, 55);
            this.buttonBai4.TabIndex = 2;
            this.buttonBai4.Text = "Bài 4";
            this.buttonBai4.UseVisualStyleBackColor = true;
            this.buttonBai4.Click += new System.EventHandler(this.buttonBai4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBai4);
            this.Controls.Add(this.buttonBai2_3);
            this.Controls.Add(this.buttonBai1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBai1;
        private Label label1;
        private Button buttonBai2_3;
        private Button buttonBai4;
    }
}