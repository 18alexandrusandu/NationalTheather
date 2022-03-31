using BusinessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IAdminService adminService;
        public WeatherForecastController(IAdminService weatherService)
        {
            this.adminService = weatherService;
        }


        [HttpGet]
        [Authorize]
        public IEnumerable<AdminModel> Get()
        {
            var result = new List<WAdminModel>();
            foreach (var w in adminService.GetAll())
            {
                result.Add(new adminService { Date = w.Date, Summary = w.Summary, TemperatureC = w.TemperatureC });
            }
            return result;
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Post(AdminModel admin)
        {
            weatherService.AddWeatherForecastModel(new AdminModel { Date = admin.Date, Summary = admin.Summary, TemperatureC = admin.TemperatureC } );
        }
    }
}
