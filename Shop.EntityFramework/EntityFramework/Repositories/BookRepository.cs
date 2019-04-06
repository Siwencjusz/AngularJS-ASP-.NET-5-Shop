using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Shop.EntityFramework.Entities;
using Shop.EntityFramework.Repositories.Interfaces;

namespace Shop.EntityFramework.Repositories
{
    public class BookRepository : ShopRepositoryBase<Book>, IBookRepository
    {
        public BookRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public List<Book> GetAllBooks()
        {
            var query = GetAll();
            return query!=null ? query.OrderBy(book => book.BookName).ToList() : new List<Book>();
        }
    }
}
