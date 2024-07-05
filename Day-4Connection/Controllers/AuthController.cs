using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        private readonly List<User> users;
    }
}

