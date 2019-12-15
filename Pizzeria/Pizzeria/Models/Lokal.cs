using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class Lokal
    {
        public Lokal()
        {
            DaneKontaktowe = new HashSet<DaneKontaktowe>();
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int IdLokal { get; set; }
        public int Nazwa { get; set; }

        public virtual ICollection<DaneKontaktowe> DaneKontaktowe { get; set; }
        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
