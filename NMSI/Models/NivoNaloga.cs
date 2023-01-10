using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class NivoNaloga
    {
        public NivoNaloga()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public string IdnivoaKorisnika { get; set; }
        public string NazivNaloga { get; set; }
        public string Idkompanije { get; set; }

        public virtual Kompanija IdkompanijeNavigation { get; set; }
        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
