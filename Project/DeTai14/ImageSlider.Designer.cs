namespace DeTai14
{
    partial class ImageSlider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageSlider));
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuPictureBoxDownload = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPictureBoxLeft = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBoxRight = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBoxDownload);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBoxLeft);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBoxRight);
            this.bunifuGradientPanel1.Controls.Add(this.textBoxLink);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepSkyBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DeepSkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1053, 899);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuPictureBoxDownload
            // 
            this.bunifuPictureBoxDownload.AllowFocused = false;
            this.bunifuPictureBoxDownload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBoxDownload.AutoSizeHeight = false;
            this.bunifuPictureBoxDownload.BorderRadius = 0;
            this.bunifuPictureBoxDownload.Image = global::DeTai14.Properties.Resources.download;
            this.bunifuPictureBoxDownload.IsCircle = true;
            this.bunifuPictureBoxDownload.Location = new System.Drawing.Point(997, 51);
            this.bunifuPictureBoxDownload.Name = "bunifuPictureBoxDownload";
            this.bunifuPictureBoxDownload.Size = new System.Drawing.Size(44, 44);
            this.bunifuPictureBoxDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBoxDownload.TabIndex = 5;
            this.bunifuPictureBoxDownload.TabStop = false;
            this.bunifuPictureBoxDownload.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBoxDownload.Click += new System.EventHandler(this.bunifuPictureBoxDownload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(76, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(901, 681);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.leftmouseDownloadClick);
            // 
            // bunifuPictureBoxLeft
            // 
            this.bunifuPictureBoxLeft.AllowFocused = false;
            this.bunifuPictureBoxLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBoxLeft.AutoSizeHeight = false;
            this.bunifuPictureBoxLeft.BorderRadius = 0;
            this.bunifuPictureBoxLeft.Image = global::DeTai14.Properties.Resources.arrow_slide_1;
            this.bunifuPictureBoxLeft.IsCircle = true;
            this.bunifuPictureBoxLeft.Location = new System.Drawing.Point(12, 502);
            this.bunifuPictureBoxLeft.Name = "bunifuPictureBoxLeft";
            this.bunifuPictureBoxLeft.Size = new System.Drawing.Size(58, 58);
            this.bunifuPictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBoxLeft.TabIndex = 3;
            this.bunifuPictureBoxLeft.TabStop = false;
            this.bunifuPictureBoxLeft.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBoxLeft.Click += new System.EventHandler(this.bunifuPictureBoxLeft_Click);
            // 
            // bunifuPictureBoxRight
            // 
            this.bunifuPictureBoxRight.AllowFocused = false;
            this.bunifuPictureBoxRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBoxRight.AutoSizeHeight = false;
            this.bunifuPictureBoxRight.BorderRadius = 0;
            this.bunifuPictureBoxRight.Image = global::DeTai14.Properties.Resources.arrow_slide;
            this.bunifuPictureBoxRight.IsCircle = true;
            this.bunifuPictureBoxRight.Location = new System.Drawing.Point(983, 502);
            this.bunifuPictureBoxRight.Name = "bunifuPictureBoxRight";
            this.bunifuPictureBoxRight.Size = new System.Drawing.Size(58, 58);
            this.bunifuPictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBoxRight.TabIndex = 3;
            this.bunifuPictureBoxRight.TabStop = false;
            this.bunifuPictureBoxRight.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBoxRight.Click += new System.EventHandler(this.bunifuPictureBoxRight_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxLink.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLink.Location = new System.Drawing.Point(321, 61);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(656, 25);
            this.textBoxLink.TabIndex = 0;
            this.textBoxLink.Text = "https://tuoitre.vn";
            this.textBoxLink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLink_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Broadway", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(182, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image Slider";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(194, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a link:";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 78;
            this.bunifuPictureBox1.Image = global::DeTai14.Properties.Resources.image_slider;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(12, 21);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(156, 156);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // ImageSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 899);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageSlider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Slider";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBoxRight;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBoxDownload;
    }
}

