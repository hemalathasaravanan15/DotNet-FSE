using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("secure")]
        [Authorize]
        public IActionResult SecureData()
        {
            return Ok("This is protected data!");
        }

        [HttpGet("public")]
        public IActionResult PublicData()
        {
            return Ok("This is public data.");
        }
    }
}
