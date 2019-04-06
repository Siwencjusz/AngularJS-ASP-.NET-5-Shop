using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace Shop.EntityFramework.Entities.Base
{
public abstract class BaseEntity : Entity<int>, IEntity, IEntity<int>
    {
        protected BaseEntity()
        {
            
        }
    }
}
