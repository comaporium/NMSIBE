using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class DodatniTroskovi
    {
        public DodatniTroskovi()
        {
            Troskovis = new HashSet<Troskovi>();
        }

        public string IddodatnogTroska { get; set; }
        public string NazivTroska { get; set; }
        public decimal Cijena { get; set; }

        public virtual ICollection<Troskovi> Troskovis { get; set; }
    }
}
