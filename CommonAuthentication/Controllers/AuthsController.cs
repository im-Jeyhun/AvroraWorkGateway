using CommonAuthentication.Token;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommonAuthentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        IConfiguration _configuration;

        public AuthsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Login(string userName , string password)
        {
            TokenHandler._configuration = _configuration;
            return Ok(userName == "avrora"&&password=="12345"? TokenHandler.CreateAccessToken() : new UnauthorizedResult());
        }
    }
}
