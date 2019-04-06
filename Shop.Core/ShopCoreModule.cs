using System.Reflection;
using Abp.Modules;

namespace Shop
{
    public class ShopCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
