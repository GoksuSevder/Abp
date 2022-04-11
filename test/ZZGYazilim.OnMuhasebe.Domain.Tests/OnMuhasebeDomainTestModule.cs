using ZZGYazilim.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ZZGYazilim.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeEntityFrameworkCoreTestModule)
    )]
public class OnMuhasebeDomainTestModule : AbpModule
{

}
