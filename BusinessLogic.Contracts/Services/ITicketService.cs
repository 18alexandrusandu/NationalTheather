using BusinessLogic.Contracts.Models;

namespace BusinessLogic.Contracts.Services
{
    public interface ITicketService
    {
        TicketModel GetById(int id);
        TicketModel[] GetTickets();


        bool Create(TicketModel ticket);
        void Update(TicketModel ticket);
        void Delete(int id);
        

        
    }
}
