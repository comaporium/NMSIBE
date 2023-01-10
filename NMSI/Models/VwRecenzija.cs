using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class VwRecenzija
    {
        public int Idrecenzije { get; set; }
        public string Idkompanije { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Ocjena { get; set; }
        public string Poruka { get; set; }
    }
}
