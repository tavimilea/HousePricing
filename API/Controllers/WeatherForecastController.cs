using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using dbtest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public HouseDatabase houseDatabase;


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastController(HouseDatabase houseDB)
        {
            this.houseDatabase = houseDB;
        }

        [HttpGet]
        public IEnumerable<double> Get()
        {
           var x = DataTrainer.TrainHouseModel(houseDatabase.Houses.ToList()).ToList();
            return x;
        }
    }
}
