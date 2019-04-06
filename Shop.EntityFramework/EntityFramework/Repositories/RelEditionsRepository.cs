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
    public class RelEditionsRepository: ShopRepositoryBase<RelEdition>, IRelEditionsRepository
    {
        public RelEditionsRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public List<RelEdition> GetAllRelEditions()
        {
            var query = GetAll();
            return query != null ? query.OrderBy(relEditions => relEditions.Name).ToList() : new List<RelEdition>();
        }
    }
}
