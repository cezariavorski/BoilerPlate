using Abp.Web.Mvc.Views;

namespace BoilerPlate.Web.Views
{
    public abstract class BoilerPlateWebViewPageBase : BoilerPlateWebViewPageBase<dynamic>
    {

    }

    public abstract class BoilerPlateWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected BoilerPlateWebViewPageBase()
        {
            LocalizationSourceName = BoilerPlateConsts.LocalizationSourceName;
        }
    }
}