using API.Entities;
using API.Services;
using dbtest;
using Microsoft.AspNetCore.Mvc;
using System.Web;
namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        //https://localhost:4300/swagger/index.html

        public TempDataAttribute token;
        private IUserService _userService;
        private HouseDatabase _userDB;
        public UsersController(IUserService userService, HouseDatabase userDB)
        {
            _userService = userService;
            _userDB = userDB;
            _userService.setDB(userDB);
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(Request request)
        {
            if (request.Create != null)
            {
                _userDB.CreateUser( request.Username, request.Password);
                return Ok();
            }
            var response = _userService.Authenticate(request);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            _userDB.SetTokenForUser(request.Username, request.Password, response.Token);
            return Ok(response);
        }


    }
}
