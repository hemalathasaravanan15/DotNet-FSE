using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProtectedController : ControllerBase
    {
        [HttpGet("data")]
        [Authorize]
        public IActionResult GetSecretData()
        {
            var username = User.Identity?.Name;
            return Ok($"🔒 Hello, {username}. This is protected data only visible with a valid token.");
        }

        [HttpGet("public")]
        [AllowAnonymous]
        public IActionResult GetPublicData()
        {
            return Ok("🌐 This is public data. No token needed.");
        }
    }
}
