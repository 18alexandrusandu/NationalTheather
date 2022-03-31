using BusinessLogic;
using BusinessLogic.Contracts;
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
    public class CahierController : ControllerBase
    {
        private readonly ICashierService cashierService;
        public CahierController(ICashierService cashierService)
        {
            this.cashierService = cashierService;
        }


        [HttpGet]
        [Authorize]
        public IEnumerable<CashierModel> Get()
        {
            var result = new List<CashierModel>();
            foreach (var w in cashierService.GetAll())
            {
                result.Add(new CashierModel { Date = w.Date, Summary = w.Summary, TemperatureC = w.TemperatureC });
            }
            return result;
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Post(CashierModel cashier)
        {
            cashierService.Create(new CashierModel { Date = cashier.Date, Summary = cashier.Summary, TemperatureC = cashier.TemperatureC } );
        }
    }
}
