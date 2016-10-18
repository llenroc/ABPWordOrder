using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using WorkOrder.EntityFramework;

namespace WorkOrder
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(WorkOrderCoreModule))]
    public class WorkOrderDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<WorkOrderDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
