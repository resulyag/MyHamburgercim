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
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }

        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            lsBoxTumSiparislerDoldur();
            lblCiro.Text = CiroHesapla().ToString("C2");
            lblToplamSiparisSayisi.Text = ToplamSiparisSayisi().ToString();
            lblExtraMalzemeGeliri.Text = ExtraMalzemeGeliriHesapla().ToString();
            lblSatilanUrunAdedi.Text = SatilanUrunAdediHesapla().ToString();
        }
        private int SatilanUrunAdediHesapla()
        {
            int adet = 0;
            foreach (var siparis in Form1.onaylananSiparisler)
            {
                adet += siparis.Adet;
            }
            return adet;
        }

        private decimal ExtraMalzemeGeliriHesapla()
        {
            decimal extraMalzemeGeliri = 0;
            foreach (var siparis in Form1.onaylananSiparisler)
            {
                foreach (var extra in siparis.Extra)
                {
                    extraMalzemeGeliri += extra.ExtraFiyati;
                }
            }
            return extraMalzemeGeliri;
        }

        private int ToplamSiparisSayisi()
        {
            int toplamSiparis = 0;
            foreach (var siparis in Form1.onaylananSiparisler)
            {
                toplamSiparis++;
            }
            return toplamSiparis;
        }

        private decimal CiroHesapla()
        {
            decimal ciro = 0;
            foreach (var siparis in Form1.onaylananSiparisler)
            {
                ciro += siparis.ToplamFiyat;
            }
            return ciro;
        }

        private void lsBoxTumSiparislerDoldur()
        {
            foreach (var siparis in Form1.onaylananSiparisler)
            {
                lsBoxTumSiparisler.Items.Add(siparis);
            }
        }
    }
}
