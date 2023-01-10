using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class Kompanija
    {
        public Kompanija()
        {
            DodatneUsluges = new HashSet<DodatneUsluge>();
            NivoNalogas = new HashSet<NivoNaloga>();
            Recenzijes = new HashSet<Recenzije>();
            Usluges = new HashSet<Usluge>();
        }

        public string Idkompanije { get; set; }
        public string NazivKompanije { get; set; }
        public string Lokacija { get; set; }
        public string OpisKompanije { get; set; }
        public string Kontakt { get; set; }

        public virtual ICollection<DodatneUsluge> DodatneUsluges { get; set; }
        public virtual ICollection<NivoNaloga> NivoNalogas { get; set; }
        public virtual ICollection<Recenzije> Recenzijes { get; set; }
        public virtual ICollection<Usluge> Usluges { get; set; }
    }
}
