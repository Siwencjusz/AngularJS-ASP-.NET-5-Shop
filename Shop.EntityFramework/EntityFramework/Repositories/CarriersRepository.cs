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
    public class CarriersRepository: ShopRepositoryBase<Carrier>, ICarriersRepository
    {
        public CarriersRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public List<Carrier> GetAllCarriers()
        {
            var query = GetAll();
            return query != null ? query.OrderBy(carrier => carrier.Name).ToList() : new List<Carrier>();
        }
    }
}
