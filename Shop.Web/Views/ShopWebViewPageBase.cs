using Abp.Web.Mvc.Views;

namespace Shop.Web.Views
{
    public abstract class ShopWebViewPageBase : ShopWebViewPageBase<dynamic>
    {

    }

    public abstract class ShopWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ShopWebViewPageBase()
        {
            LocalizationSourceName = ShopConsts.LocalizationSourceName;
        }
    }
}