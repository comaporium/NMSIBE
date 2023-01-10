using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class Recenzije
    {
        public string Idrecenzije { get; set; }
        public string Idkorisnika { get; set; }
        public string Idkompanije { get; set; }
        public string Ocjena { get; set; }
        public string Poruka { get; set; }

        public virtual Kompanija IdkompanijeNavigation { get; set; }
        public virtual Korisnik IdkorisnikaNavigation { get; set; }
    }
}
