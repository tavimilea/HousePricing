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
        public static IEnumerable<double> TrainHouseModel(List<House> houses) {
            IEnumerable<IEnumerable<double>> mappedData = MapHouseData(houses);
            IEnumerable<double> mappedPrices = MapPrices(houses);
            Matrix<double> HouseSampleData = DenseMatrix.OfRows(mappedData);
            Matrix<double> Prices = DenseMatrix.OfColumnArrays(mappedPrices.ToArray());
            var SampleTransposed = HouseSampleData.Transpose();
            var product = SampleTransposed.Multiply(HouseSampleData);
            var productInv = product.Inverse();
            var result = productInv.Multiply(SampleTransposed).Multiply(Prices);
            //Matrix<double> TrainedModel = HouseSampleData.Transpose().Multiply(HouseSampleData).Inverse().Multiply(HouseSampleData.Transpose()).Multiply(Prices);
            List<double> constants = result.EnumerateColumns().FirstOrDefault().ToList();
            return constants;
        }

        private static List<List<double>> MapHouseData(List<House> houses) {
            List<List<double>> HouseData = new List<List<double>> ();
            foreach(House house in houses)  {
                List<double> currentHouseDescriptor = new List<double> ();
                currentHouseDescriptor.Add(house.Condition);
                currentHouseDescriptor.Add(house.Date);
                currentHouseDescriptor.Add(house.Floors);
                currentHouseDescriptor.Add(house.Lat);
               // currentHouseDescriptor.Add(house.Longg);
                currentHouseDescriptor.Add(house.Sqft_living);
                currentHouseDescriptor.Add(house.Sqft_living15);
                currentHouseDescriptor.Add(house.Sqft_lot15);
                currentHouseDescriptor.Add(house.Sqft_lot);
                currentHouseDescriptor.Add(house.Yr_built);
               // currentHouseDescriptor.Add(house.Yr_renovated);
               // currentHouseDescriptor.Add(house.Zipcode);
               // currentHouseDescriptor.Add(house.Waterfront);
                currentHouseDescriptor.Add(house.Grade);
                //currentHouseDescriptor.Add(house.View);
                currentHouseDescriptor.Add(house.Grade);
                currentHouseDescriptor.Add(house.Sqft_above);
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
