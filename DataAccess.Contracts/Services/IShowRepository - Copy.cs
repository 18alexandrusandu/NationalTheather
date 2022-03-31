using DataAccess.Contracts.Models;

namespace DataAccess.Contracts.Services
{
    public interface IShowRepository
    {
        ShowDto GetById(int id);
        ShowDto[] GetAll();

        bool Create(ShowDto show);
        void Update(ShowDto show);

        void Delete(int id);
    }
}
