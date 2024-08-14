using LogIn.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Models;
using Service.Services.Interface;
using WebApplication1.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        // POST api/<AuthController>
        [HttpPost]
        public string LogIn([FromBody] LoginRequest request)
        {
            var result = _authService.LogIn(request);
            return result;
        }

        // POST api/<AuthController>/5
        [HttpPost("addUser")]
        public User AddUser([FromBody] User user)
        {
            var users = _authService.AddUser(user);
            return users;
        }

        
    }
}
