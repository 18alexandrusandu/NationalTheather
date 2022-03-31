using BusinessLogic.Contracts;
using BusinessLogic.Contracts.Models;
using BusinessLogic.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TicketsController : ControllerBase
    {
   
        private readonly ITicketService _ticketService;
        public TicketsController( ITicketService ticketService)
        {

            _ticketService = ticketService;
           
        }


        [HttpGet("Tickets")]
        [AllowAnonymous]
        public async Task<List<TicketModel>> GetTickets()
        {
            var result = await _ticketService.GetTickets();
            return result;
        }

        [HttpPost("CreatTicket")]
        [AllowAnonymous]
        public async Task<bool> CreateTicket([FromBody] Ticketodel ticketModel)
        {
         
            
            var result = await _ticketService.CreateTicket(ticketModel);
            return (result != null);
        }




        [HttpGet("ExportTickets")]
        [AllowAnonymous]
        public async Task<bool> ExportTicket([FromBody] TicketModel ticketModel)
        {


            var result = await _ticketService.CreateTicket(ticketModel);
            return (result != null);
        }




        [HttpGet("TicketsForShow")]
        [AllowAnonymous]
        public async Task<List<TicketModel>> GetTicketsForShows(ShowModel show)
        {
            var TicketList = new List<TicketModel>();
            foreach (var ticket in _ticketService.Tickets.ToList())
            {
                var ticketModel = new RoleModel
                {
                    Id = role.Id,
                    RoleName = role.Name
                };
                rolesList.Add(roleModel);
            }
            return rolesList;
        }
    }
}
