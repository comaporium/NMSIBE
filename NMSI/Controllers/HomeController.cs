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
    public class HomeController : ControllerBase
    {
        Car_Sharing_PlatformContext db = new Car_Sharing_PlatformContext();
        [HttpGet]
        public IActionResult sveUsluge()
        {
            List<DodatneUsluge> sveUsluge = db.DodatneUsluges.OrderBy(x => x.IddodatneUsluge).ToList();
            return Ok(sveUsluge);
        }
    }
}
