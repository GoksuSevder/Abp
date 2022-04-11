using ZZGYazilim.OnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ZZGYazilim.OnMuhasebe.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OnMuhasebeController : AbpControllerBase
{
    protected OnMuhasebeController()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}
