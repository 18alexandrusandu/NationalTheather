
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogic.Contracts.Models;
using BusinessLogic.Contracts.Services;
namespace Presentation.Controllers
{
    [Route("api/shows")]
    [ApiController]
    [AllowAnonymous]
    public class ShowController : ControllerBase
    {
        private readonly IShowService _showService;
     


        public ShowController(IShowService showService)
        {
            
            _showService = showService;
           
        }

    
        [HttpPost("CreateShow")]
        [Authorize(Roles = "Admin")]
        public async Task<ShowModel> Create([FromBody] ShowModel show)
        {

            var result = await _showSerivce.Create(show);
            return result;
        }


        [HttpPut("UpdateShow")]
        [Authorize(Roles = "Admin")]
        public async Task<ShowModel> Update([FromBody] ShowModel show)
        {

            var result = await _showSerivce.Update(show);
            return result;
        }




        [HttDelete("DeleteShow")]
        [Authorize(Roles = "Admin")]
        public async Task<bool> DeleteShows([FromBody] ShowModel show)
        {
            bool result = await _showService.Delete();
            return result;
        }








    }
}
