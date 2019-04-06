using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using SimpleTaskSystem;

namespace Shop
{
    [DependsOn(typeof(ShopCoreModule), typeof(AbpAutoMapperModule))]
    public class ShopApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                DtoMappings.Map(mapper);
            });
        }
    }
}
