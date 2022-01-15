using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHamburgercim
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Extra> Extra { get; set; }
        public int Adet { get; set; }
        public decimal ToplamFiyat { get; set; }

        public void Hesapla()
        {
            // gelen sepet siparişin seçilen bilgilere göre fiyatı düzenleniyor

            ToplamFiyat = Menu.MenuFiyati;

            switch (Boyut)
            {
                case Boyut.Orta:
                    ToplamFiyat += 3;
                    break;
                case Boyut.Buyuk:
                    ToplamFiyat += 5;
                    break;
            }

            foreach (var extra in this.Extra)
            {
                ToplamFiyat += extra.ExtraFiyati;
            }

            ToplamFiyat *=this.Adet;

        }
        public override string ToString()
        {
            return  this.Menu.MenuAdi + ", " + this.Adet + " Adet, " + this.Boyut + " Boy, " + ToplamFiyat + " TL";
        }
    }
}
