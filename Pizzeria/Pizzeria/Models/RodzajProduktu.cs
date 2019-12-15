using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class RodzajProduktu
    {
        public RodzajProduktu()
        {
            Produkt = new HashSet<Produkt>();
        }

        public int IdRodzajProduktu { get; set; }
        public string Nazwa { get; set; }

        public virtual ICollection<Produkt> Produkt { get; set; }
    }
}
