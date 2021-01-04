using API.Entities;
using API.Services;
using dbtest;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private UsersDatabase _userDB;
        public UsersController(IUserService userService, UsersDatabase userDB)
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
                _userDB.CreateUser(request.Id, request.Username, request.Password);
                return Ok();
            }
            var response = _userService.Authenticate(request);
            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }


    }
}
