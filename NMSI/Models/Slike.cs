using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class Slike
    {
        public string Idslike { get; set; }
        public string Idusluge { get; set; }
        public string Urlslike { get; set; }

        public virtual Usluge IduslugeNavigation { get; set; }
    }
}
