using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Web;

namespace Lab04
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }
        public class DataObjects
        {
            public int? page { get; set; }
            public int? per_page { get; set; }
            public int? total { get; set; }
            public int? total_pages { get; set; }
            public List<DataItems>? data { get; set; }
        }
        public class DataItems
        {
            public int? id { get; set; }
            public string? email { get; set; }
            public string? first_name { get; set; }
            public string? last_name { get; set; }
            public string? avatar { get; set; }
        }
        public static readonly HttpClient client = new();
        private async void Bai05_Load(object sender, EventArgs e)
        {
            var response = await client.GetFromJsonAsync<DataObjects>("https://reqres.in/api/users?page=1");
            flowLayoutPanel1.Controls.Clear();
            lbPage.Text += ' ' + response.page.ToString();
            lbTotalPage.Text += ' ' + response.total_pages.ToString();
            lbUsers.Text += ' ' + response.per_page.ToString();
            lbTotalUsers.Text += ' ' + response.total.ToString();
            for (int i = 0; i < response.data.Count; i++)
            {
                var byteArray = await client.GetByteArrayAsync(response.data[i].avatar);
                using MemoryStream ms = new(byteArray);
                flowLayoutPanel1.Controls.Add(new ListItem
                {
                    Title = response.data[i].first_name + ' ' + response.data[i].last_name,
                    Message = response.data[i].email,
                    Icon = Image.FromStream(ms)
                }
                );
            }
        }
        private void GoUp(object sender, EventArgs e)
        {
            int tick = flowLayoutPanel1.VerticalScroll.Value - flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, tick);
        }
        private void GoDown(object sender, EventArgs e)
        {
            int tick = flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, tick);
        }
    }
}
