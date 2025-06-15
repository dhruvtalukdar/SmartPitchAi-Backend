using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartPitchAi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpGet("random")]
        public IActionResult GetRandomData()
        {
            var randomData = new
            {
                Message = "This is a random message from the AuthenticationController.",
                Timestamp = DateTime.UtcNow
            };
            return Ok(randomData);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAccountAsync()
        {
            // Simulate account registration logic
            await Task.Delay(1000); // Simulating async operation
            var response = new
            {
                Message = "Account registered successfully.",
                Timestamp = DateTime.UtcNow
            };
            return Ok(response);
        }
    }

}
