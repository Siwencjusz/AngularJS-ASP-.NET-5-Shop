using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Shop.EntityFramework;

namespace Shop
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ShopCoreModule))]
    public class ShopDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ShopDbContext>(null);
        }
    }
}
