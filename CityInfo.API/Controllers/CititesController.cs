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
        public IActionResult GetCities()
        {
            //            Less favorable way of implementing a status code, depends on returning a JsonResult
            //            var temp =  new JsonResult(CitiesDataStore.Current.Cities);
            //            temp.StatusCode == 200;
            //            return temp;


            // Not 404 is required because an empty list is a valid response
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")] // equivalent to [HttpGet("api/cities/{id}")] due to Controller level Route
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null)
            {
                return NotFound(); // If exceptions other than "NotFound" occur, the Framework results a 500 Internal Server Error
            }

            return Ok(cityToReturn);
        }
    }
}
