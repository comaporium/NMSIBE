using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class VwSveOuslugama
    {
        public string Idusluge { get; set; }
        public string Model { get; set; }
        public decimal Cijena { get; set; }
        public string BrojSjedista { get; set; }
        public DateTime DatumIstekaRegistracije { get; set; }
        public string Snaga { get; set; }
        public string NazivKompanije { get; set; }
        public string Urlslike { get; set; }
        public string Vrsta { get; set; }
    }
}
