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
    public class PublishersRepository: ShopRepositoryBase<Publisher>, IPublisherRepository
    {
        public PublishersRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public List<Publisher> GetAllPublishers()
        {
            var query = GetAll();
            return query != null ? query.OrderBy(publisher => publisher.Name).ToList() : new List<Publisher>();
        }
    }
}
