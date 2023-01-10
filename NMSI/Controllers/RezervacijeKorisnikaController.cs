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
    public class RezervacijeKorisnikaController : ControllerBase
    {
        Car_Sharing_PlatformContext db = new Car_Sharing_PlatformContext();
        [HttpGet]
        public IActionResult sveRezervacije()
        {
            List<VwRezervacijeKorisnika> sveRezervacije = db.VwRezervacijeKorisnikas.OrderBy(x => x.Idrezervacije).ToList();
            return Ok(sveRezervacije);
        }
    }
}
