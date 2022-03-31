using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts.Models;
namespace DataAccess.Repositories
{
    class TicketRepository
    {
        private readonly IList<TicketDto> inMemoryTickets = new List<TicketDto>();

        public TicketRepository()
        {
            // set some mocking data:
            inMemoryTickets.Add(new TicketDto { Id = 1, Author = "Ken Follet", Name = "Century Trillogy", YearOfPublishing = 1990 });
            inMemoryTickets.Add(new TicketDto { Id = 2, Author = "J. K. Rowling", Name = "Harry Potter", YearOfPublishing = 1997 });
        }

        public TicketDto GetById(int id)
        {
            return inMemoryTickets.First(x => x.Id == id);
        }

        public TicketDto[] GetAll()
        {
            return inMemoryTickets.ToArray();
        }

        public bool Add(TicketDto Ticket)
        {
            inMemoryTickets.Add(Ticket);
            return true;
        }

        public void Update(TicketDto Ticket)
        {
            inMemoryTickets[inMemoryTickets.IndexOf(inMemoryTickets.First(x => x.Id == Ticket.Id))] = Ticket;
        }

        public void Delete(int id)
        {
            inMemoryTickets.RemoveAt(inMemoryTickets.IndexOf(inMemoryTickets.First(x => x.Id == id)));
        }
    }
}
}
