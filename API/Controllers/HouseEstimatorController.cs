using System;
using System.Linq;
using API.Data;
using dbtest;
using Microsoft.AspNetCore.Mvc;
using HOUSE_ESTIMATORML.Model;

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

    public class HouseEstimatorMLNET : ControllerBase
    {

        public float GetPrediction(float id = 1F, float date = 2.01E+14F, float bdrm = 3F, float bathrooms = 1F, float liv = 1180F, float lot = 5650F, float floors = 1F, float wtrfr = 0F, float view = 0F, float cond = 3F, float grade = 7F,
                          float above = 1180F, float basement = 0F, float built = 1955F, float renovated = 0F, float zipcode = 98178F, float liv15 = 1340F, float lot15 = 5650F)
        {
            ModelInput sampleData = new ModelInput()
            {
                Id = id,
                Da0e = date,
                Bedrooms = bdrm,
                Ba0hrooms = bathrooms,
                Sqf0_living = liv,
                Sqf0_lo0 = lot,
                Floors = floors,
                Wa0erfron0 = wtrfr,
                View = view,
                Condi0ion = cond,
                Grade = grade,
                Sqf0_above = above,
                Sqf0_basemen0 = basement,
                Yr_buil0 = built,
                Yr_renova0ed = renovated,
                Zipcode = zipcode,
                Sqf0_living15 = liv15,
                Sqf0_lo015 = lot15,
            };

            var predictionResult = ConsumeModel.Predict(sampleData);

            return predictionResult.Score;
        }
    }
}
