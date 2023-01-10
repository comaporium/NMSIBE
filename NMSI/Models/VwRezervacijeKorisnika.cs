using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class VwRezervacijeKorisnika
    {
        public string Idrezervacije { get; set; }
        public string Idkorisnika { get; set; }
        public string Idusluge { get; set; }
        public string Model { get; set; }
        public decimal CijenaUsluge { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string IddodatneUsluge { get; set; }
        public string NazivDodatneUsluge { get; set; }
        public decimal CijenaDodatneUsluge { get; set; }
    }
}
