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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            CmBoxMenuDoldur();
            ExtralarDoldur();
            ListBoxSepetDoldur();
            ToplamFiyatHesapla();

        }

        public void ExtralarDoldur()
        {
            foreach (var extra in Form1.extralar)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = extra.ExtraAdi;
                flowLayoutPanel1.Controls.Add(checkBox);
            }
        }

        public void CmBoxMenuDoldur()
        {
            cmBoxMenu.DataSource = Form1.menuler;
            cmBoxMenu.DisplayMember = "MenuAdi";
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();

            yeniSiparis.Menu = (Menu)cmBoxMenu.SelectedItem;
            if (radioButtonKucuk.Checked)
            {
                yeniSiparis.Boyut = Boyut.Kucuk;
            }
            else if (radioButtonOrta.Checked)
            {
                yeniSiparis.Boyut = Boyut.Orta;
            }
            else if (radioButtonBuyuk.Checked)
            {
                yeniSiparis.Boyut = Boyut.Buyuk;
            }

            yeniSiparis.Extra = new List<Extra>();
            foreach (var checkBox in flowLayoutPanel1.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    yeniSiparis.Extra.Add(Form1.extralar[checkBox.TabIndex]);
                }
            }

            yeniSiparis.Adet = Convert.ToInt32(numericUpDownAdet.Value);

            yeniSiparis.Hesapla();
            Form1.sepetSiparisler.Add(yeniSiparis);

            ListBoxSepetDoldur();
            ToplamFiyatHesapla();

            Fonksiyon.Temizle(this.Controls);
        }
        public void ListBoxSepetDoldur()
        {
            listBoxSepet.Items.Clear();
            foreach (var siparis in Form1.sepetSiparisler)
            {
                listBoxSepet.Items.Add(siparis.ToString());
            }
        }
        public decimal ToplamFiyatHesapla()
        {
            txtToplamFiyat.Text = "";
            decimal toplamFiyat = 0;
            foreach (var siparis in Form1.sepetSiparisler)
            {
                toplamFiyat += siparis.ToplamFiyat;
            }
            txtToplamFiyat.Text = toplamFiyat.ToString("C2");
            return toplamFiyat;
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam sipariş ücreti : " + ToplamFiyatHesapla().ToString("C2") + " Satın almayı tamamlamak istiyor musunuz ? ", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                foreach (var siparis in Form1.sepetSiparisler)
                {
                    Form1.onaylananSiparisler.Add(siparis);
                }
                Form1.sepetSiparisler.Clear();
                listBoxSepet.Items.Clear();
                MessageBox.Show("Siparişiniz Tamamlanmıştır!!!");
            }
        }
    }
}
