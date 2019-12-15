using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class Produkt
    {
        public Produkt()
        {
            ProduktSkladnik = new HashSet<ProduktSkladnik>();
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int IdProdukt { get; set; }
        public string Nazwa { get; set; }
        public int Cena { get; set; }
        public bool CzyNowy { get; set; }
        public int IdRodzajProduktu { get; set; }
        public int? IdPromocja { get; set; }
        public int? IdRozmiarProduktu { get; set; }

        public virtual Promocja IdPromocjaNavigation { get; set; }
        public virtual RodzajProduktu IdRodzajProduktuNavigation { get; set; }
        public virtual RozmiarProduktu IdRozmiarProduktuNavigation { get; set; }
        public virtual ICollection<ProduktSkladnik> ProduktSkladnik { get; set; }
        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
