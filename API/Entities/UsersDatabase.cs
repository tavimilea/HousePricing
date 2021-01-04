using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using API.Entities;
using API.Services;
using System;
using System.Linq;
using System.Collections.Generic;

namespace dbtest
{
    public class UsersDatabase : DbContext
    {
        private IUserService _userService;
        public DbSet<User> Users { get; set; }
        private static bool _created = false;
        public UsersDatabase([NotNullAttribute] DbContextOptions options) : base(options)
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        public void CreateUser(int Id, string Username, string Password)
        {
            User user = new User(Id, Username, Password);
            Users.Add(user);
            this.SaveChanges();
        }

        public List<User> GetAll()
        {
            return Users.ToList();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=users.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
        }

    }
}
