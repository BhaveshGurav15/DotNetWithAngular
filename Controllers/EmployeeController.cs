using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ngWithJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("GetUserData")]
        //[Authorize(Policy = Policies.User)]
        public IActionResult GetUserData()
        {
            return Ok("This is Employee");
        }
    }
}
