using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SystemController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("ConnectionString")]
        public IActionResult GetConnectionString()
        {
            string connectionString = _configuration.GetConnectionString("PostgreSQLConnectionString");

            if (string.IsNullOrEmpty(connectionString))
            {
                return NotFound("Connection string not found.");
            }

            return Ok(connectionString);
        }
    }
}
