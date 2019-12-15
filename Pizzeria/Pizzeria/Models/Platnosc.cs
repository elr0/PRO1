using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class Platnosc
    {
        public Platnosc()
        {
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int IdPlatnosc { get; set; }
        public string RodzajPlatnosci { get; set; }
        public string Link { get; set; }

        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
