using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class Usluge
    {
        public Usluge()
        {
            Rezervacijas = new HashSet<Rezervacija>();
            Slikes = new HashSet<Slike>();
        }

        public string Idusluge { get; set; }
        public string Idvrste { get; set; }
        public string NazivUsluge { get; set; }
        public string Model { get; set; }
        public decimal Cijena { get; set; }
        public string Idkompanije { get; set; }
        public string BrojSjedista { get; set; }
        public DateTime DatumIstekaRegistracije { get; set; }
        public string Snaga { get; set; }
        public string DodatneInformacije { get; set; }

        public virtual Kompanija IdkompanijeNavigation { get; set; }
        public virtual VrstaUsluge IdvrsteNavigation { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
        public virtual ICollection<Slike> Slikes { get; set; }
    }
}
