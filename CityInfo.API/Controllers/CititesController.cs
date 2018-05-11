using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
//    [Route("api/[controller]")] // tells MVC to use the prefix of the controller name, E.G. Cities, will change route if classname changes
    [Route("api/cities")]
    public class CititesController : Controller
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new { id = 1, name = "New York City"},
                new { id = 2, name = "Antwerp"}
            });
        }
    }
}
