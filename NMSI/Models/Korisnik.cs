using System;
using System.Collections.Generic;

#nullable disable

namespace NMSI.Models
{
    public partial class Korisnik
    {
        public Korisnik()
        {
            Recenzijes = new HashSet<Recenzije>();
            Rezervacijas = new HashSet<Rezervacija>();
        }

        public string Idkorisnika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public string IdnivoaKorisnika { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual NivoNaloga IdnivoaKorisnikaNavigation { get; set; }
        public virtual ICollection<Recenzije> Recenzijes { get; set; }
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
