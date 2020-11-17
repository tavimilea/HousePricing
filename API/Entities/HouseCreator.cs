using System;

namespace dbtest
{
    public class HouseCreator : Creator
    {
        public override House FactoryMethod()
        {
            return new House();
        }

        public static House CreateHouse(string[] cells)
        {
            return new House
            {
                Id = Convert.ToDouble(cells[0].Trim('"')),
                Date = cells[1],
                Price = Convert.ToDouble(cells[2]),
                Bedrooms = Convert.ToInt32(cells[3]),
                Bathrooms = float.Parse(cells[4]),
                Sqft_living = Convert.ToInt32(cells[5]),
                Sqft_lot = Convert.ToInt32(cells[6]),
                Floors = float.Parse(cells[7].Trim('"')),
                Waterfront = Convert.ToInt32(cells[8]),
                View = Convert.ToInt32(cells[9]),
                Condition = Convert.ToInt32(cells[10]),
                Grade = Convert.ToInt32(cells[11]),
                Sqft_above = Convert.ToInt32(cells[12]),
                Sqft_basement = Convert.ToInt32(cells[13]),
                Yr_built = Convert.ToInt32(cells[14]),
                Yr_renovated = Convert.ToInt32(cells[15]),
                Zipcode = Convert.ToInt32(cells[16].Trim('"')),
                Lat = float.Parse(cells[17]),
                Longg = float.Parse(cells[18]),
                Sqft_living15 = Convert.ToInt32(cells[19]),
                Sqft_lot15 = Convert.ToInt32(cells[20])
            };
        }
    }
}