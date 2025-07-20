using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthAPI.Models; // Adjust this based on your project structure

namespace JwtAuthAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (IsValidUser(model))
            {
                var token = GenerateJwtToken(model.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }

        // Dummy user validation
        private bool IsValidUser(LoginModel model)
        {
            // In real-world apps, validate against DB
            return model.Username == "admin" && model.Password == "password";
        }

        private string GenerateJwtToken(string username)
{
    var claims = new[]
    {
        new Claim(ClaimTypes.Name, username)
    };

    // 🔐 Validate and load key safely
    var jwtKey = _config["Jwt:Key"];
    if (string.IsNullOrEmpty(jwtKey) || jwtKey.Length < 32)
    {
        throw new Exception("JWT Key is invalid or too short. Must be at least 32 characters.");
    }

    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

    var token = new JwtSecurityToken(
        issuer: _config["Jwt:Issuer"],
        audience: _config["Jwt:Audience"],
        claims: claims,
        expires: DateTime.Now.AddMinutes(Convert.ToDouble(_config["Jwt:DurationInMinutes"])),
        signingCredentials: creds
    );

    return new JwtSecurityTokenHandler().WriteToken(token);
}

    }
}
