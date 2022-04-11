using System.Threading.Tasks;

namespace ZZGYazilim.OnMuhasebe.Data;

public interface IOnMuhasebeDbSchemaMigrator
{
    Task MigrateAsync();
}
