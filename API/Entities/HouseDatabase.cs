using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;


namespace dbtest
{
    public class HouseDatabase : DbContext
    {
        public DbSet<House> Houses { get; set; }

        private static bool _created = false;
        public HouseDatabase()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
            if(Houses.ToList().Count() == 0)
            {
                loadFromCSV("kc_house_data.csv");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=Baza.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>().ToTable("Houses");
        }

        public void loadFromCSV(string filename)
        {
            var readcsv = File.ReadAllText(filename);
            string[] rows = readcsv.Split('\n');
            var houses = this.Set<House>();

            for (int i = 1; i <= 50; i++)
            {
                string[] cells = rows[i].Split(',');
                House house = this.createHouse(cells);
                houses.Add(house);
                this.SaveChanges();
            }
        }

        private House createHouse(string[] cells)
        {
            House house = new House
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

            return house;
        }
                
    }
}
