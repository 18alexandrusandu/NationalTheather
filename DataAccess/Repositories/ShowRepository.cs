using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contracts.Services;
namespace DataAccess.Repositories
{
    class ShowRepository:IShowRepository
    {
        private readonly IList<ShowDto> inMemoryBooks = new List<ShowDto>();

        public BookRepository()
        {
            // set some mocking data:
            inMemoryBooks.Add(new BookDto { Id = 1, Author = "Ken Follet", Name = "Century Trillogy", YearOfPublishing = 1990 });
            inMemoryBooks.Add(new BookDto { Id = 2, Author = "J. K. Rowling", Name = "Harry Potter", YearOfPublishing = 1997 });
        }

        public BookDto GetById(int id)
        {
            return inMemoryBooks.First(x => x.Id == id);
        }

        public BookDto[] GetAll()
        {
            return inMemoryBooks.ToArray();
        }

        public bool Add(BookDto book)
        {
            inMemoryBooks.Add(book);
            return true;
        }

        public void Update(BookDto book)
        {
            inMemoryBooks[inMemoryBooks.IndexOf(inMemoryBooks.First(x => x.Id == book.Id))] = book;
        }

        public void Delete(int id)
        {
            inMemoryBooks.RemoveAt(inMemoryBooks.IndexOf(inMemoryBooks.First(x => x.Id == id)));
        }
    }
}
}
