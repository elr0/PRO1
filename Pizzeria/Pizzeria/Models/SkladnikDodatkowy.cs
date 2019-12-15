using System;
using System.Collections.Generic;

namespace Pizzeria.Models
{
    public partial class SkladnikDodatkowy
    {
        public SkladnikDodatkowy()
        {
            ZamowienieSkladnikDodatkowy = new HashSet<ZamowienieSkladnikDodatkowy>();
        }

        public int IdSkladnikDodatkowy { get; set; }
        public int SkladnikIdSkladnik { get; set; }

        public virtual Skladnik SkladnikIdSkladnikNavigation { get; set; }
        public virtual ICollection<ZamowienieSkladnikDodatkowy> ZamowienieSkladnikDodatkowy { get; set; }
    }
}
