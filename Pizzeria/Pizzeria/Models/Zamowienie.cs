using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class Zamowienie
    {
        public Zamowienie()
        {
            ZamowienieSkladnikDodatkowy = new HashSet<ZamowienieSkladnikDodatkowy>();
        }

        public int IdZamowienie { get; set; }
        public int IdProdukt { get; set; }
        public int IdUzytkownik { get; set; }
        public int IdDostawa { get; set; }
        public int IdPlatnosc { get; set; }
        public int IdLokal { get; set; }
        public decimal Cena { get; set; }

        public virtual Dostawa IdDostawaNavigation { get; set; }
        public virtual Lokal IdLokalNavigation { get; set; }
        public virtual Platnosc IdPlatnoscNavigation { get; set; }
        public virtual Produkt IdProduktNavigation { get; set; }
        public virtual Uzytkownik IdUzytkownikNavigation { get; set; }
        public virtual ICollection<ZamowienieSkladnikDodatkowy> ZamowienieSkladnikDodatkowy { get; set; }
    }
}
