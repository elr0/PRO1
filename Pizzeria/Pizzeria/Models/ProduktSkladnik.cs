using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class ProduktSkladnik
    {
        public int IdProduktSkladnik { get; set; }
        public int IdProdukt { get; set; }
        public int IdSkladnik { get; set; }

        public virtual Produkt IdProduktNavigation { get; set; }
        public virtual Skladnik IdSkladnikNavigation { get; set; }
    }
}
