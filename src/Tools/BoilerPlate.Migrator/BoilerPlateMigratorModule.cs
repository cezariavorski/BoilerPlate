using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using BoilerPlate.EntityFramework;

namespace BoilerPlate.Migrator
{
    [DependsOn(typeof(BoilerPlateDataModule))]
    public class BoilerPlateMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<BoilerPlateDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}