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
    public class VwSveOuslugamaController : ControllerBase
    {
        Car_Sharing_PlatformContext db = new Car_Sharing_PlatformContext();
        [HttpGet]
        public IActionResult sveUsluge()
        {
            List<VwSveOuslugama> usluge = db.VwSveOuslugamas.OrderBy(x => x.Idusluge).ToList();
            return Ok(usluge);
        }

        [HttpGet]
        public IActionResult jednaUsluga(string id)
        {
            List<VwSveOuslugama> usluga = db.VwSveOuslugamas.Where(x => x.Idusluge.Equals(id)).ToList();
            return Ok(usluga);
        }

        [HttpPost]
        public IActionResult upisRezervacije([FromBody] Rezervacija podaci)
        {
            db.Add(podaci);
            db.SaveChanges();
            return Ok(podaci);
        }
    }
}
