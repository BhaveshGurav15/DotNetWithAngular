using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ngWithJwt.Models;
using ngWithJwt.Repository;
using ngWithJwt.Utility;

namespace ngWithJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IOptions<MySettingsModel> appSettings;

        public EmployeeController(IOptions<MySettingsModel> app)
        {
            appSettings = app;
        }

        [HttpGet]
        [Route("GetEmployeeData")]
        //[Authorize(Policy = Policies.User)]
        public IActionResult GetUserData()
        {
            var data = DbClientFactory<EmployeeDbClient>.Instance.GetAllEmployee(appSettings.Value.DbConn);
            return Ok(data);
        }
    }
}
