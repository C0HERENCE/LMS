using LMS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LMS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LMSEntityFrameworkCoreModule),
    typeof(LMSApplicationContractsModule)
    )]
public class LMSDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
