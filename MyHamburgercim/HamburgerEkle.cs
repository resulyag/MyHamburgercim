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
    public partial class HamburgerEkle : Form
    {
        public HamburgerEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"İşlem tamamlansın mı ?", @"Uyarı",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

            if (result.Equals(DialogResult.OK))
            {
                Menu yeniHamburger = new Menu();
                yeniHamburger.MenuAdi = txtHamburgerAdi.Text;
                yeniHamburger.MenuFiyati = (Decimal)numericUpDownHamburgerFiyati.Value;
                Form1.menuler.Add(yeniHamburger);
                MessageBox.Show("Menüye '" + yeniHamburger.MenuAdi + "' Eklendi");
                this.Hide();
            }  
        }
    }
}
