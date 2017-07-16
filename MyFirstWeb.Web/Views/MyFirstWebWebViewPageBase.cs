using Abp.Web.Mvc.Views;

namespace MyFirstWeb.Web.Views
{
    public abstract class MyFirstWebWebViewPageBase : MyFirstWebWebViewPageBase<dynamic>
    {

    }

    public abstract class MyFirstWebWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyFirstWebWebViewPageBase()
        {
            LocalizationSourceName = MyFirstWebConsts.LocalizationSourceName;
        }
    }
}