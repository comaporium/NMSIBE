using Microsoft.AspNetCore.Mvc;
using NMSI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NMSI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class KorisnikController : ControllerBase
    {
        Car_Sharing_PlatformContext db = new Car_Sharing_PlatformContext();

        [HttpGet]
        public IActionResult sviKorisnici()
        {
            List<Korisnik> korisnici = db.Korisniks.OrderBy(x => x.Idkorisnika).ToList();
            return Ok(korisnici);
        }

        [HttpGet]
        public IActionResult jedanKorisnik(string id)
        {
            List<Korisnik> korisnik = db.Korisniks.Where(x => x.Idkorisnika.Equals(id)).ToList();
            return Ok(korisnik);
        }
    }
}
