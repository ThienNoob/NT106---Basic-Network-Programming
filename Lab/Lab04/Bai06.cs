using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace Lab04
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }
        private readonly HttpClient client = new();
        private async void btGET_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new();
            var htmlDoc = web.Load(URL.Text);
            var articles = htmlDoc.DocumentNode?.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article");
            ListItem[] webItem = new ListItem[articles.Count];
            int i = 0;
            foreach (var article in articles)
            {
                var title = article.SelectSingleNode("./h2")?.InnerText.Trim();
                var description = article.SelectSingleNode("./p")?.InnerText.Trim();
                var url = article.SelectSingleNode("./h2/a")?.Attributes["href"].Value;
                if (title == null || description == null || url == null)
                    continue;
                string imgUrl = "";
                if (article.SelectSingleNode("./div/a/picture/source")?.Attributes["srcset"]?.Value == null)
                    imgUrl = article.SelectSingleNode("./div/a/picture/source")?.Attributes["data-srcset"]?.Value;
                else
                    imgUrl = article.SelectSingleNode("./div/a/picture/source")?.Attributes["srcset"]?.Value;
                if (imgUrl.Contains("data"))
                {
                    //Match Regex
                    var base64Data = Regex.Match(imgUrl, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
                    var binData = Convert.FromBase64String(base64Data);
                    using MemoryStream ms1 = new(binData);
                    webItem[i] = new ListItem
                    {
                        Title = title,
                        Message = description,
                        Icon = Image.FromStream(ms1)
                    };
                    flowLayoutPanel1.Controls.Add(webItem[i]);
                    webItem[i].NameClick += (sender, e) => LoadWebSite(sender, e, url);
                }
                if (imgUrl.Contains("https"))
                {
                    string httpUri = imgUrl.Split(',')[0];
                    httpUri = imgUrl.Remove(httpUri.Length - 2);
                    var byteArray = await client.GetByteArrayAsync(httpUri);
                    using MemoryStream ms2 = new(byteArray);
                    webItem[i] = new ListItem
                    {
                        Title = title,
                        Message = description,
                        Icon = Image.FromStream(ms2)
                    };
                    flowLayoutPanel1.Controls.Add(webItem[i]);
                    webItem[i].NameClick += (sender, e) => LoadWebSite(sender, e, url);
                }
                i++;
            }
        }
        private void LoadWebSite(object sender, EventArgs e, string url)
        {
            if (webView21 == null || webView21.CoreWebView2 == null)
                webView21.Source = new Uri(url);
            else
                webView21.CoreWebView2.Navigate(url);
        }
    }
}
