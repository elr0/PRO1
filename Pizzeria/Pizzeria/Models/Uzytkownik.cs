using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class Uzytkownik
    {
        public Uzytkownik()
        {
            DaneKontaktowe = new HashSet<DaneKontaktowe>();
            Zamowienie = new HashSet<Zamowienie>();
        }

        public int IdUzytkownik { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Haslo { get; set; }

        public virtual ICollection<DaneKontaktowe> DaneKontaktowe { get; set; }
        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
