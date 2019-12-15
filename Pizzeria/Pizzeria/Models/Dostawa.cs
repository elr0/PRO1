using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class Dostawa
    {
        public Dostawa()
        {
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int IdDostawa { get; set; }
        public string Rodzaj { get; set; }
        public decimal Cena { get; set; }

        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
