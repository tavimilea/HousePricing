using API.Entities;
using API.Helpers;
using dbtest;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace API.Services
{
    public interface IUserService
    {
        Response Authenticate(Request request);
        IEnumerable<User> GetAll();
        User GetById(int id);
        void setDB(UsersDatabase usersDB);
    }
    public class UserService : IUserService
    {
        public UsersDatabase _usersDB;
        private DbSet<User> _users;
        private readonly AppSettings _appSettings;
        public void setDB(UsersDatabase usersDB)
        {
            _usersDB = usersDB;
            _users = usersDB.Users;
        }
        public UserService(IOptions<AppSettings> appSettings, UsersDatabase usersDB)
        {
            _appSettings = appSettings.Value;
            _usersDB = usersDB;
            _users = usersDB.Users;
        }
        public Response Authenticate(Request model)
        {
            var user = this._users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if (user == null)
                return null;
            var token = generateJwtToken(user);
            return new Response(user, token);
        }
        private string generateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        public IEnumerable<User> GetAll()
        {
            return _users;
        }
        public User GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}
