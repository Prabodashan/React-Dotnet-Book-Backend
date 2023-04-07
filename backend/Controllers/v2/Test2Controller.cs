using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers.v2
{
    //[ApiVersion("2.0")]
    [Route("api/[controller]")]
    //[Route("api/v{Version:apiVersion}/[controller]")]
    [ApiController]
    public class Test2Controller : ControllerBase
    {
        [HttpGet("get-test-data")]
        public IActionResult Get()
        {
            return Ok("This is Test Controller v2");
        }
    }
}
