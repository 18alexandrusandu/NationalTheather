using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts.Models;
namespace DataAccess.Contracts.Services
{
   public interface IShowMapper
    {

        public CashierDto GetById(int id);


        public CashierDto[] GetAll();


        public bool Add(CashierDto Cashier);

        public void Update(CashierDto Cashier);

        public void Delete(int id);

    }
}
