using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Shop.EntityFramework.Entities;
using Shop.EntityFramework.Entities.Base;

namespace Shop.EntityFramework.Repositories.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        List<Book> GetAllBooks();
    }
}