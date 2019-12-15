using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class DaneKontaktowe
    {
        public int IdDaneKontaktowe { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public int NumerMieszkania { get; set; }
        public string NumerTel { get; set; }
        public int IdUzytkownik { get; set; }
        public int IdLokal { get; set; }

        public virtual Lokal IdLokalNavigation { get; set; }
        public virtual Uzytkownik IdUzytkownikNavigation { get; set; }
    }
}
