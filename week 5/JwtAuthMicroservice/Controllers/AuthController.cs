using Microsoft.AspNetCore.Mvc;
using JwtAuthMicroservice.Data;
using JwtAuthMicroservice.Models;
using JwtAuthMicroservice.Services;

namespace JwtAuthMicroservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly JwtService _jwtService;

        public AuthController(AppDbContext context, JwtService jwtService)
        {
            _context = context;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);

            if (user == null) return Unauthorized("Invalid credentials");

            var token = _jwtService.GenerateToken(user);
            return Ok(new { Token = token });
        }
    }
}
