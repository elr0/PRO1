using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class RozmiarProduktu
    {
        public RozmiarProduktu()
        {
            Produkt = new HashSet<Produkt>();
        }

        public int IdRozmiarProduktu { get; set; }
        public string Nazwa { get; set; }
        public int Szerokosc { get; set; }
        public int Mnoznik { get; set; }

        public virtual ICollection<Produkt> Produkt { get; set; }
    }
}
