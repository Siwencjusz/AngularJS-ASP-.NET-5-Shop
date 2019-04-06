using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Shop.EntityFramework.Entities;

namespace Shop.EntityFramework.Repositories.Interfaces
{
    public interface IPublisherRepository : IRepository<Publisher>
    {
        List<Publisher> GetAllPublishers();
    }
}
