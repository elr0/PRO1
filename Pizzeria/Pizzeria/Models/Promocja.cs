using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class Promocja
    {
        public Promocja()
        {
            Produkt = new HashSet<Produkt>();
        }

        public int IdPromocja { get; set; }
        public DateTime Start { get; set; }
        public DateTime Koniec { get; set; }
        public int Rabat { get; set; }

        public virtual ICollection<Produkt> Produkt { get; set; }
    }
}
