using BusinessLogic.Contracts.Models;

namespace BusinessLogic.Contracts.Services
{
    public interface IShowService
    {
        ShowModel GetById(int id);
        ShowModel[] GetAll();

        bool Create(ShowModel show);
        void Update(ShowModel show);
        void Delete(int id);

        
    }
}
