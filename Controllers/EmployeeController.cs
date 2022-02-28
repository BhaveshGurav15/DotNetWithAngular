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
        public IActionResult GetEmployeeData()
        {
            var data = DbClientFactory<EmployeeDbClient>.Instance.GetAllEmployee(appSettings.Value.DbConn);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetEmployee/{id}")]
        //[Authorize(Policy = Policies.User)]
        public IActionResult GetEmployee(int id)
        {
            var data = DbClientFactory<EmployeeDbClient>.Instance.GetEmployeeById(appSettings.Value.DbConn,id);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetChart")]
        //[Authorize(Policy = Policies.User)]
        public IActionResult GetDesignationwiseSalaryChart()
        {
            var data = DbClientFactory<EmployeeDbClient>.Instance.GetDesignationwiseSalary(appSettings.Value.DbConn);
            return Ok(data);
        }
    }
}
