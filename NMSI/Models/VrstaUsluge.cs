using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class VrstaUsluge
    {
        public VrstaUsluge()
        {
            Usluges = new HashSet<Usluge>();
        }

        public string Idvrste { get; set; }
        public string Vrsta { get; set; }

        public virtual ICollection<Usluge> Usluges { get; set; }
    }
}
