using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using BoilerPlate.EntityFramework;

namespace BoilerPlate
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(BoilerPlateCoreModule))]
    public class BoilerPlateDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BoilerPlateDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
