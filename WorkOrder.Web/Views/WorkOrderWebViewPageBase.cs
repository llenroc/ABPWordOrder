using Abp.Web.Mvc.Views;

namespace WorkOrder.Web.Views
{
    public abstract class WorkOrderWebViewPageBase : WorkOrderWebViewPageBase<dynamic>
    {

    }

    public abstract class WorkOrderWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected WorkOrderWebViewPageBase()
        {
            LocalizationSourceName = WorkOrderConsts.LocalizationSourceName;
        }
    }
}