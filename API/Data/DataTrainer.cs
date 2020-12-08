using dbtest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathNet;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace API.Data
{
    public class DataTrainer
    {
        public static Matrix<double> TrainedModel;

        public static double EvaluateHouse(House house)
        {
            if (TrainedModel == null)
            {
                throw new Exception("model was not trained");
            }

            List<House> houseData = new List<House>();
            houseData.Add(house);
            IEnumerable<IEnumerable<double>> mappedHouseData = MapHouseData(houseData);
            Matrix<double> houseDescriptor = DenseMatrix.OfRows(mappedHouseData);
            return TrainedModel.Multiply(houseDescriptor).Enumerate().FirstOrDefault();

        }
        public static  void TrainHouseModel(List<House> houses) {
            IEnumerable<IEnumerable<double>> mappedData = MapHouseData(houses.Where(h => h.Id < 10).ToList());
            IEnumerable<double> mappedPrices = MapPrices(houses.Where(h => h.Id < 10).ToList());
            Matrix<double> HouseSampleData = DenseMatrix.OfRows(mappedData);
            Matrix<double> Prices = DenseMatrix.OfColumnArrays(mappedPrices.ToArray());
            Matrix<double> SampleTransposed = HouseSampleData.Transpose();
            Matrix<double> product = SampleTransposed.Multiply(HouseSampleData);
            Matrix<double> productInv = product.Inverse();
            TrainedModel = productInv.Multiply(HouseSampleData.Transpose()).Multiply(Prices);
            //Matrix<double> TrainedModel = HouseSampleData.Transpose().Multiply(HouseSampleData).Inverse().Multiply(HouseSampleData.Transpose()).Multiply(Prices);
            //-198146.73066943558
        }

        private static List<List<double>> MapHouseData(List<House> houses) {
            List<List<double>> HouseData = new List<List<double>> ();
            foreach(House house in houses)  {
                List<double> currentHouseDescriptor = new List<double> ();
                currentHouseDescriptor.Add(house.Condition);
                //currentHouseDescriptor.Add(house.Date);
                currentHouseDescriptor.Add(house.Floors);
                //currentHouseDescriptor.Add(house.Lat);
               //currentHouseDescriptor.Add(house.Longg);
               // currentHouseDescriptor.Add(house.Sqft_living);
                //currentHouseDescriptor.Add(house.Sqft_living15);
                //currentHouseDescriptor.Add(house.Sqft_lot15);
                //currentHouseDescriptor.Add(house.Sqft_lot);
                //currentHouseDescriptor.Add(house.Yr_built);
               // currentHouseDescriptor.Add(house.Yr_renovated);
               // currentHouseDescriptor.Add(house.Zipcode);
               // currentHouseDescriptor.Add(house.Waterfront);
                currentHouseDescriptor.Add(house.Grade);
                //currentHouseDescriptor.Add(house.View);
                //currentHouseDescriptor.Add(house.Grade);
                //currentHouseDescriptor.Add(house.Sqft_above);
                //currentHouseDescriptor.Add(house.Sqft_basement);
                HouseData.Add(currentHouseDescriptor);
            }
            return HouseData;
        }

        private static List<double> MapPrices(List<House> houses) {
            List<double> prices = new List<double> ();
            foreach(House house in houses)  {
                prices.Add(house.Price);
            }
            return prices;
        }
    }
}
