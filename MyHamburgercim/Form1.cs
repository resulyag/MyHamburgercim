using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHamburgercim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu()
            {
                MenuAdi="Cheese Burger Menu",
                MenuFiyati=15.0m
            },
            new Menu()
            {
                MenuAdi="Whopper Burger Menu",
                MenuFiyati=12.0m
            }
        };
        public static List<Extra> extralar = new List<Extra>()
        {
            new Extra()
            {
                ExtraAdi="Hardal",
                ExtraFiyati=2.0m
            },
            new Extra()
            {
                ExtraAdi="Ketçap",
                ExtraFiyati=2.0m
            }
        };
        public static List<Siparis> sepetSiparisler = new List<Siparis>();


        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisOlustur siparisOlustur = new SiparisOlustur();
            siparisOlustur.MdiParent = this;
            siparisOlustur.Dock = DockStyle.Fill;
            siparisOlustur.Show();
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HamburgerEkle hamburgerEkle = new HamburgerEkle();  
            hamburgerEkle.MdiParent = this;
            hamburgerEkle.Dock = DockStyle.Fill;
            hamburgerEkle.Show();
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtraMalzemeEkle extraMalzemeEkle = new ExtraMalzemeEkle();
            extraMalzemeEkle.MdiParent = this;
            extraMalzemeEkle.Dock = DockStyle.Fill;
            extraMalzemeEkle.Show();
        }
    }
}
