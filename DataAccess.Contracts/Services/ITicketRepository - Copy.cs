using DataAccess.Contracts.Models;

namespace DataAccess.Contracts.Services
{
    public interface IBookRepository
    {
        BookDto GetById(int id);
        BookDto[] GetAll();

        bool Add(TicketDto ticket);
        void Update(TicketDto ticket);

        void Delete(int id);
    }
}
