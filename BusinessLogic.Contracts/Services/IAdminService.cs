using BusinessLogic.Contracts.Models;

namespace BusinessLogic.Contracts.Services
{
    public interface ICashierService
    {
        CashierModel GetById(int id);
        CashierModel[] GetAll();

        bool Create(CashierModel cashier);
        void Update(CashierModel cashier);
        void Delete(int id);

        
    }
}
