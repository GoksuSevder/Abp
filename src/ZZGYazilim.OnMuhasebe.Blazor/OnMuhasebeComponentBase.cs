using ZZGYazilim.OnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ZZGYazilim.OnMuhasebe.Blazor;

public abstract class OnMuhasebeComponentBase : AbpComponentBase
{
    protected OnMuhasebeComponentBase()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}
