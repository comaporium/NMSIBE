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
    public class RecenzijeController : ControllerBase
    {
        Car_Sharing_PlatformContext db = new Car_Sharing_PlatformContext();
        [HttpPost]
        public IActionResult upisRecenzije([FromBody] Recenzija podaci)
        {
            db.Add(podaci);
            db.SaveChanges();
            return Ok(podaci);
        }
    }
}
