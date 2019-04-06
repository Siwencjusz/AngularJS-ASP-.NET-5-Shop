using Abp.Web.Mvc.Controllers;

namespace Shop.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ShopControllerBase : AbpController
    {
        protected ShopControllerBase()
        {
            LocalizationSourceName = ShopConsts.LocalizationSourceName;
        }
    }
}