using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class Skladnik
    {
        public Skladnik()
        {
            ProduktSkladnik = new HashSet<ProduktSkladnik>();
            SkladnikDodatkowy = new HashSet<SkladnikDodatkowy>();
        }

        public int IdSkladnik { get; set; }
        public string Nazwa { get; set; }
        public decimal? Wartosc { get; set; }

        public virtual ICollection<ProduktSkladnik> ProduktSkladnik { get; set; }
        public virtual ICollection<SkladnikDodatkowy> SkladnikDodatkowy { get; set; }
    }
}
