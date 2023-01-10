using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class Troskovi
    {
        public string IdtroskovaRezervacije { get; set; }
        public string Idrezervacije { get; set; }
        public string IddodatnogTroska { get; set; }
        public DateTime DatumTroska { get; set; }
        public string Kolicina { get; set; }

        public virtual DodatniTroskovi IddodatnogTroskaNavigation { get; set; }
        public virtual Rezervacija IdrezervacijeNavigation { get; set; }
    }
}
