using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts.Models;
namespace DataAccess.Contracts.Services
{
    interface IShowRepository
    {
        public ShowDto GetById(int id);


        public ShowDto[] GetAll();


        public bool Add(ShowDto Show);

        public void Update(ShowDto Show);

        public void Delete(int id);
    }
}
