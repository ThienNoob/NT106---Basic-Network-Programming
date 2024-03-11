namespace Lab04
{
    partial class Ba0i4_ViewSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ba0i4_ViewSource));
            this.txtWEBView = new System.Windows.Forms.RichTextBox();
            this.txtURLView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWEBView
            // 
            this.txtWEBView.Location = new System.Drawing.Point(10, 31);
            this.txtWEBView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWEBView.Name = "txtWEBView";
            this.txtWEBView.Size = new System.Drawing.Size(680, 299);
            this.txtWEBView.TabIndex = 0;
            this.txtWEBView.Text = "";
            // 
            // txtURLView
            // 
            this.txtURLView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtURLView.Location = new System.Drawing.Point(10, 6);
            this.txtURLView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtURLView.Name = "txtURLView";
            this.txtURLView.Size = new System.Drawing.Size(340, 23);
            this.txtURLView.TabIndex = 1;
            // 
            // Ba0i4_ViewSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.txtURLView);
            this.Controls.Add(this.txtWEBView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ba0i4_ViewSource";
            this.Text = "fBai4_ViewSource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RichTextBox txtWEBView;
        public TextBox txtURLView;
    }
}