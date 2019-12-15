using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class ZamowienieSkladnikDodatkowy
    {
        public int IdZamowienieSkladnikDodatkowy { get; set; }
        public int SkladnikDodatkowyIdSkladnikDodatkowy { get; set; }
        public int ZamowienieIdZamowienie { get; set; }

        public virtual SkladnikDodatkowy SkladnikDodatkowyIdSkladnikDodatkowyNavigation { get; set; }
        public virtual Zamowienie ZamowienieIdZamowienieNavigation { get; set; }
    }
}
