using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class DodatneUsluge
    {
        public DodatneUsluge()
        {
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public string IddodatneUsluge { get; set; }
        public string NazivDodatneUsluge { get; set; }
        public string OpisDodatneUsluge { get; set; }
        public decimal Cijena { get; set; }
        public string Idkompanije { get; set; }

        public virtual Kompanija IdkompanijeNavigation { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
