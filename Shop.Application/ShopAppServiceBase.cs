using Abp.Application.Services;

namespace Shop
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ShopAppServiceBase : ApplicationService
    {
        protected ShopAppServiceBase()
        {
            LocalizationSourceName = ShopConsts.LocalizationSourceName;
        }
    }
}