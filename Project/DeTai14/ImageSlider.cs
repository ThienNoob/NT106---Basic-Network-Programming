using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net.Http;
using HtmlAgilityPack;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace DeTai14
{
    public partial class ImageSlider : Form
    {
        public ImageSlider()
        {
            InitializeComponent();
        }
        private readonly HttpClient client = new HttpClient();
        int index = 0;
        List<Image> imageCollections = new List<Image>();
        private void bunifuPictureBoxDownload_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to download all images?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                foreach (var img in imageCollections)
                {
                    Bitmap bmp = new Bitmap(img);
                    if (sfd.ShowDialog() == DialogResult.OK)
                        bmp.Save(sfd.FileName);
                }
            }
            else
                return;
        }
        private void bunifuPictureBoxLeft_Click(object sender, EventArgs e)
        {
            --index;
            if (index < 0)
                index = imageCollections.Count - 1;
            pictureBox1.Image = imageCollections[index];
        }
        private void bunifuPictureBoxRight_Click(object sender, EventArgs e)
        {
            ++index;
            if (index == imageCollections.Count)
                index = 0;
            pictureBox1.Image = imageCollections[index];
        }

        private async void textBoxLink_KeyDown(object sender, KeyEventArgs e)
        {
            index = 0;
            imageCollections.Clear();
            try
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                    HtmlWeb web = new HtmlWeb();
                    var htmlDoc = web.Load(textBoxLink.Text);
                    if (textBoxLink.Text == "https://tuoitre.vn" || textBoxLink.Text == "https://tuoitre.vn/")
                    {
                        var imgArticles = htmlDoc.DocumentNode?.SelectNodes("//div[@class='box-category-item']//img/@src");
                        foreach (var img in imgArticles)
                        {
                            var imgUrl = img.GetAttributeValue("src", "");
                            if (imgUrl == null)
                                continue;
                            var selectedImgStream = await client.GetStreamAsync(imgUrl);
                            Bitmap bmp = new Bitmap(selectedImgStream);
                            Bitmap resizedBmp = ResizeImage(bmp, pictureBox1.Width, pictureBox1.Height);
                            imageCollections.Add(resizedBmp);
                        }
                    }
                    else if (textBoxLink.Text == "https://nhandan.vn" || textBoxLink.Text == "https://nhandan.vn/")
                    {
                        var imgArticles = htmlDoc.DocumentNode?.SelectNodes("//img[substring(@src, string-length(@src) - 3) = '.jpg']");
                        foreach (var img in imgArticles)
                        {
                            var imgUrl = img.GetAttributeValue("src", "");
                            if (imgUrl.Contains(','))
                                imgUrl = imgUrl.Split(',')[0];
                            var selectedImgStream = await client.GetStreamAsync(imgUrl);
                            Bitmap bmp = new Bitmap(selectedImgStream);
                            Bitmap resizedBmp = ResizeImage(bmp, pictureBox1.Width, pictureBox1.Height);
                        }
                    }
                    else if (textBoxLink.Text == "https://vnexpress.net/the-gioi/tu-lieu" || textBoxLink.Text == "https://vnexpress.net/the-gioi/tu-lieu/")
                    {
                        var imgArticles = htmlDoc.DocumentNode?.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article");
                        foreach (var img in imgArticles)
                        {
                            string imgUrl = "";
                            if (img.SelectSingleNode("./div/a/picture/source")?.Attributes["srcset"]?.Value == null)
                                imgUrl = img.SelectSingleNode("./div/a/picture/source")?.Attributes["data-srcset"]?.Value;
                            else
                                imgUrl = img.SelectSingleNode("./div/a/picture/source")?.Attributes["srcset"]?.Value;
                            if (imgUrl == null)
                            {
                                continue;
                            }
                            if (imgUrl.Contains("data"))
                            {
                                //Match Regex
                                var base64Data = Regex.Match(imgUrl, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
                                var binData = Convert.FromBase64String(base64Data);
                                MemoryStream ms1 = new MemoryStream(binData);
                                Bitmap bmp1 = new Bitmap(ms1);
                                Bitmap resizedBmp1 = ResizeImage(bmp1, pictureBox1.Width, pictureBox1.Height);
                                imageCollections.Add(resizedBmp1);
                            }
                            if (imgUrl.Contains("https"))
                            {
                                string httpUri = imgUrl.Split(',')[0];
                                httpUri = imgUrl.Remove(httpUri.Length - 2);
                                var byteArray = await client.GetByteArrayAsync(httpUri);
                                MemoryStream ms2 = new MemoryStream(byteArray);
                                Bitmap bmp2 = new Bitmap(ms2);
                                Bitmap resizedBmp2 = ResizeImage(bmp2, pictureBox1.Width, pictureBox1.Height);
                                imageCollections.Add(resizedBmp2);
                            }
                        }
                    }
                    pictureBox1.Image = imageCollections[index];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                ImageAttributes wrapMode = new ImageAttributes();
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            }
            return destImage;
        }
        private void leftmouseDownloadClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            if (e.Button == MouseButtons.Left)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                    bmp.Save(sfd.FileName);
            }
        }
    }
}
