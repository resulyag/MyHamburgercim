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
            cmBoxMenu.DataSource = Form1.menuler;
            cmBoxMenu.DisplayMember = "MenuAdi";

            foreach (var extra in Form1.extralar)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = extra.ExtraAdi;
                flowLayoutPanel1.Controls.Add(checkBox);
            }

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
            yeniSiparis.ToString();
            Form1.sepetSiparisler.Add(yeniSiparis);
            for (int i = Form1.sepetSiparisler.Count-1; i > Form1.sepetSiparisler.Count-2; i--)
            {
                listBoxSepet.Items.Add(Form1.sepetSiparisler[i]);
            }


            //foreach (var siparis in Form1.sepetSiparisler)
            //{
            //    listBoxSepet.Items.Clear();
            //    listBoxSepet.Items.Add(siparis);
            //}


        }
    }
}
