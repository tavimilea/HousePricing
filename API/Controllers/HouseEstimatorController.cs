using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using dbtest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using HOUSE_ESTIMATORML.Model;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HouseEstimatorController : ControllerBase
    {
        public HouseDatabase houseDatabase;


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public HouseEstimatorController(HouseDatabase houseDB)
        {
            this.houseDatabase = houseDB;
        }

        [HttpGet("{floors}/{grade}/{condition}")]
        public double Get(double floors, double grade, double condition)
        {
            House hs = new House();
            hs.Floors = floors;
            hs.Grade = grade;
            hs.Condition = condition;
            if(DataTrainer.TrainedModel == null)
            {
                DataTrainer.TrainHouseModel(houseDatabase.Houses.ToList());
            }
            return Math.Abs(DataTrainer.EvaluateHouse(hs)) / 10;
        }
    }
}
