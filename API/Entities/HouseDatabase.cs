using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Diagnostics.CodeAnalysis;
using API.Entities;

namespace dbtest
{
    public class HouseDatabase : DbContext
    {
        public DbSet<House> Houses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EstimationRequest> Requests { get; set; }

        public DbSet<Report> Reports { get; set; }
        private static bool _created = false;


        public HouseDatabase([NotNullAttribute] DbContextOptions options) : base(options) //config
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
            if (Houses.ToList().Count() == 0)
            {
                loadFromCSV("kc_house_data.csv"); //load la csv ul de train
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=houses.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<House>().ToTable("Houses");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Report>();
        }

        public void loadFromCSV(string filename)
        {
            var readcsv = File.ReadAllText(filename);
            string[] rows = readcsv.Split('\n');
            var houses = this.Set<House>();

            for (int i = 1; i < 400; i++)
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
                Id = int.Parse(cells[0]),
                Date = double.Parse(cells[1]),
                Price = double.Parse(cells[2]),
                Bedrooms = double.Parse(cells[3]),
                Bathrooms = double.Parse(cells[4]),
                Sqft_living = double.Parse(cells[5]),
                Sqft_lot = double.Parse(cells[6]),
                Floors = double.Parse(cells[7].Trim('"')),
                Waterfront = double.Parse(cells[8]),
                View = double.Parse(cells[9]),
                Condition = double.Parse(cells[10]),
                Grade = double.Parse(cells[11]),
                Sqft_above = double.Parse(cells[12]),
                Sqft_basement = double.Parse(cells[13]),
                Yr_built = double.Parse(cells[14]),
                Yr_renovated = double.Parse(cells[15]),
                Zipcode = double.Parse(cells[16].Trim('"')),
                Sqft_living15 = double.Parse(cells[17]),
                Sqft_lot15 = double.Parse(cells[18])
            };

            return house;
        }

        public List<User> GetAllUsers()
        {
            return Users.ToList();
        }

        public void CreateUser( string Username, string Password)
        {
            User user = new User( Username, Password);
            Users.Add(user);
            this.SaveChanges();
        }

        public void AddRequest(EstimationRequest r)
        {
            Requests.Add(r);
            this.SaveChanges();
        }

        public void AddReport(EstimationRequest r, string token)
        {
            var requestTOLink = Requests.FirstOrDefault(rq => rq.Id == r.Id);
            var userToLink = Users.FirstOrDefault(usr => usr.Token == token); //cauta prin useri
            Report report = new Report();
            Reports.Add(report);
            report.User = userToLink;
            report.Request = requestTOLink;
            this.SaveChanges();
        }
        public void SetTokenForUser(string id, string password, string newToken)
        {
            Users.FirstOrDefault(usr => usr.Password == password && usr.Username == id).Token = newToken; //update token
            this.SaveChanges();
        }

        public bool tokenExists(string token) {
            if(Users.FirstOrDefault(usr => usr.Token == token) != null)
            {
                return true;
            }
            return false;
        }

    }
}
