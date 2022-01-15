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
    public partial class ExtraMalzemeEkle : Form
    {
        public ExtraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtExtraAdi.Text == String.Empty)
            {
                errorProvider1.SetError(txtExtraAdi, "Lütfen extra ismini giriniz!!!");
            }
            else
            {
                var result = MessageBox.Show(@"İşlem tamamlansın mı ?", @"Uyarı",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question);

                if (result.Equals(DialogResult.OK))
                {
                    Extra yeniExtra = new Extra();
                    yeniExtra.ExtraAdi = txtExtraAdi.Text;
                    yeniExtra.ExtraFiyati = (decimal)numericUpDownExtraFiyati.Value;
                    Form1.extralar.Add(yeniExtra);
                    MessageBox.Show("Extra malzemelere ' " + yeniExtra.ExtraAdi + " ' Eklendi");
                    Fonksiyon.Temizle(this.Controls);
                }
            }


        }
    }
}
