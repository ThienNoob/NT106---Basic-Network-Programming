using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class fBai4 : Form
    {
        public fBai4()
        {
            InitializeComponent();
        }

        public class LoaiXang
        {
            public string namePetro { get; set; }
            public int price { get; set; }
        }
        LoaiXang lx1 = new LoaiXang() { namePetro = "Xăng RON 95-III", price = 26830 };
        LoaiXang lx2 = new LoaiXang() { namePetro = "Xăng E5 92-II", price = 26070 };
        LoaiXang lx3 = new LoaiXang() { namePetro = "Dầu DO 0,05S-II", price = 21310 };



        private void label3_Click(object sender, EventArgs e)
        {

        }
        public class Vehicle
        {
            public string name { get; set; }
            public double dungtich { get; set; }
            public double MucTieuHaoNhienLieu { get; set; }

            public LoaiXang[] loaiXangs { get; set; }


        }

        private void fBai4_Load(object sender, EventArgs e)
        {

        }
        List<Vehicle> l;
        private void button1_Click(object sender, EventArgs e)
        {
            l = new List<Vehicle>()
            {
                new Vehicle () { name="Wave Alpha",dungtich=3.7,MucTieuHaoNhienLieu=1.6,loaiXangs= new LoaiXang[] {lx1,lx2} },
                new Vehicle () { name="Sirius",dungtich=3.8,MucTieuHaoNhienLieu=1.99,loaiXangs= new LoaiXang[] {lx1,lx2} },
                new Vehicle () { name="Vision",dungtich=5.2,MucTieuHaoNhienLieu=1.87,loaiXangs= new LoaiXang[] {lx1,lx2} },
                new Vehicle () { name="Lead",dungtich=6,MucTieuHaoNhienLieu=2.02,loaiXangs= new LoaiXang[] {lx1} },
                new Vehicle () { name="Winner",dungtich=4.5,MucTieuHaoNhienLieu=1.7,loaiXangs= new LoaiXang[] {lx1} },
                new Vehicle () { name="AirBlade",dungtich=4.4,MucTieuHaoNhienLieu=2.17,loaiXangs= new LoaiXang[] {lx1} },
                new Vehicle () { name="Xe tải 9 tấn",dungtich=70,MucTieuHaoNhienLieu=13,loaiXangs= new LoaiXang[] {lx3} }


            };
            cbB_loaixe.DataSource = l;
            cbB_loaixe.DisplayMember = "Name";
            Vehicle lchoose = cbB_loaixe.SelectedValue as Vehicle;
            tB_dungtich.Text = "" + lchoose.dungtich + " lít";
            tB_muctieuhao.Text = lchoose.MucTieuHaoNhienLieu + "lít/100km ";
            cbB_LoaiXang.DataSource = lchoose.loaiXangs;
            cbB_LoaiXang.DisplayMember = "namePetro";

            LoaiXang lxChoose = cbB_LoaiXang.SelectedValue as LoaiXang;
            tB_tien.Text = String.Format("{0:n}", Math.Round((lchoose.dungtich * lxChoose.price), 2) ) + "VND";
            tx_soKm.Text = Math.Round((lchoose.dungtich / lchoose.MucTieuHaoNhienLieu * 100), 2) + "km";

        }

        private void cbB_loaixe_SelectedValueChanged(object sender, EventArgs e)
        {
           
            
            Vehicle lchoose = cbB_loaixe.SelectedValue as Vehicle;
            tB_dungtich.Text = "" + lchoose.dungtich + " lít";
            tB_muctieuhao.Text = lchoose.MucTieuHaoNhienLieu + "lít/100km ";
            cbB_LoaiXang.DataSource = lchoose.loaiXangs;
            cbB_LoaiXang.DisplayMember = "namePetro";

            LoaiXang lxChoose = cbB_LoaiXang.SelectedValue as LoaiXang;
            tB_tien.Text = String.Format("{0:n}", Math.Round((lchoose.dungtich * lxChoose.price), 2)) + "VND";
            tx_soKm.Text = Math.Round((lchoose.dungtich / lchoose.MucTieuHaoNhienLieu * 100),2) + "km";
        }

        private void cbB_LoaiXang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Vehicle lchoose = cbB_loaixe.SelectedValue as Vehicle;
            tB_dungtich.Text = "" + lchoose.dungtich + " lít";
            tB_muctieuhao.Text = lchoose.MucTieuHaoNhienLieu + "lít/100km ";
            cbB_LoaiXang.DataSource = lchoose.loaiXangs;
            cbB_LoaiXang.DisplayMember = "namePetro";

            LoaiXang lxChoose = cbB_LoaiXang.SelectedValue as LoaiXang;
            tB_tien.Text = String.Format("{0:n}", Math.Round((lchoose.dungtich * lxChoose.price), 2)) + "VND";
            tx_soKm.Text = Math.Round((lchoose.dungtich / lchoose.MucTieuHaoNhienLieu * 100), 2) + "km";
        }
    }
}
