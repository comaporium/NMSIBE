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
    public class KompanijeController : ControllerBase
    {
        Car_Sharing_PlatformContext db = new Car_Sharing_PlatformContext();

        [HttpGet]
        public IActionResult sveKompanije()
        {
            List<Kompanija> kompanije = db.Kompanijas.OrderBy(x => x.Idkompanije).ToList();
            return Ok(kompanije);
        }

        [HttpGet]
        public IActionResult recenzije()
        {
            List<VwRecenzija> recenzije = db.VwRecenzijas.OrderByDescending(x => x.Idrecenzije).ToList();
            return Ok(recenzije);
        }

        [HttpGet]
        public IActionResult sveRecenzije(string id)
        {
            List<VwRecenzija> recenzije = db.VwRecenzijas.Where(x => x.Idkompanije.Equals(id)).ToList();
            return Ok(recenzije);
        }
    }
}
