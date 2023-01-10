using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class Rezervacija
    {
        public Rezervacija()
        {
            Troskovis = new HashSet<Troskovi>();
        }

        public string Idrezervacije { get; set; }
        public string Idkorisnika { get; set; }
        public string Idusluge { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string IddodatneUsluge { get; set; }

        public virtual DodatneUsluge IddodatneUslugeNavigation { get; set; }
        public virtual Korisnik IdkorisnikaNavigation { get; set; }
        public virtual Usluge IduslugeNavigation { get; set; }
        public virtual ICollection<Troskovi> Troskovis { get; set; }
    }
}
