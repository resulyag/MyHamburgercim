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

        public void Hesapla()
        {
            switch (Boyut)
            {
                case Boyut.Orta:
                    this.Menu.MenuFiyati += 3;
                    break;
                case Boyut.Buyuk:
                    this.Menu.MenuFiyati += 5;
                    break;
            }

            //switch (Extra)
            //{
            //    case 
            //        break;
            //}
            foreach (var extra in this.Extra)
            {
                this.Menu.MenuFiyati += extra.ExtraFiyati;
            }

            this.Menu.MenuFiyati *=this.Adet;

        }
        //public override string ToString()
        //{
        //    var Goster = this.Menu.MenuAdi + ", " + this.Adet + " Adet, " + this.Boyut + " Boy, ( " +   this.Extra.+" )";

        //    return "";
        //}
        //private void ExtraBas()
        //{
        //    foreach (var extra in this.Extra)
        //    {
        //        extra.ExtraAdi
        //    }
        //}

    }
}
