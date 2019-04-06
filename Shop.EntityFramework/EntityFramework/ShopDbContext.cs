using System.Data.Entity;
using Abp.EntityFramework;
using Shop.EntityFramework.Entities;

namespace Shop.EntityFramework
{
    public class ShopDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */

        public virtual IDbSet<Author> Authors { get; set; }
        public virtual IDbSet<BookType> BookTypes { get; set; }
        public virtual IDbSet<Publisher> Publishers { get; set; }
        public virtual IDbSet<Book> Books { get; set; }
        public virtual IDbSet<Cover> Covers { get; set; }
        public virtual IDbSet<Carrier> Carriers { get; set; }
        public virtual IDbSet<RelEdition> RelEditions { get; set; }
        public ShopDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ShopDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ShopDbContext since ABP automatically handles it.
         */
        public ShopDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
