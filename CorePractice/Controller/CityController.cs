using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CorePractice.Controller
{
    [ApiController]
    public class CityController:ControllerBase
    {
        [HttpGet("api/city")]
        public JsonResult GetCity()
        {

            var ss = new List<CityModel>
            {
                new CityModel
                {
                    Id=1,
                    Name="Hyderabad",
                    Description="Great City"
                },
                new CityModel
                {
                    Id=2,
                    Name="Banglore",
                    Description="Good City"
                }
            };
            return new JsonResult(ss);
        }
   }
}
