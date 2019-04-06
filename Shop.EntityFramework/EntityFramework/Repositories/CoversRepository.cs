﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using Shop.EntityFramework.Entities;
using Shop.EntityFramework.Repositories.Interfaces;

namespace Shop.EntityFramework.Repositories
{
    public class CoversRepository: ShopRepositoryBase<Cover>, ICoversRepository
    {
        public CoversRepository(IDbContextProvider<ShopDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public List<Cover> GetAllCovers()
        {
            var query = GetAll();
            return query != null ? query.OrderBy(cover => cover.Name).ToList() : new List<Cover>();
        }
    }
}
