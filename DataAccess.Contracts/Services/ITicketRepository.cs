using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts.Services
{
    interface ITicketRepository
    {

        public CashierDto GetById(int id);


        public CashierDto[] GetAll();


        public bool Add(CashierDto Cashier);

        public void Update(CashierDto Cashier);

        public void Delete(int id);
    }
}
