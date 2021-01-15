using System;
using System.Linq;
using API.Data;
using API.Entities;
using dbtest;
using Microsoft.AspNetCore.Mvc;
//using HOUSE_ESTIMATORML.Model;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HouseEstimatorController : ControllerBase
    {
        public HouseDatabase houseDatabase;

        public HouseEstimatorController(HouseDatabase houseDB)
        {
            this.houseDatabase = houseDB;
        }

        [HttpPost("estimate")]
        public ResponseAuth Estimate(EstimationRequestWrapper request)
        {
            if(!houseDatabase.tokenExists(request.Token)) //Verofoca daca tokenul este corect
            {
                ResponseAuth r = new ResponseAuth("Bad Auth TOken");
                return r;
            }
            House hs = new House();
            hs.Floors = request.Floors;
            hs.Grade = request.Grade;
            hs.Condition = request.Condition;

            EstimationRequest req = request.UnrwrapEstimation(); //Creeaza obiectul de reqest pe care il salvez ib DB
            houseDatabase.AddRequest(req);
            houseDatabase.AddReport(req, req.Token); 

            if(DataTrainer.TrainedModel == null)
            {
                DataTrainer.TrainHouseModel(houseDatabase.Houses.ToList());
            }
            return new ResponseAuth( (Math.Abs(DataTrainer.EvaluateHouse(hs)) / 10).ToString());
        }
    }
}
