using LMS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LMS.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LMSPageModel : AbpPageModel
{
    protected LMSPageModel()
    {
        LocalizationResourceType = typeof(LMSResource);
    }
}
