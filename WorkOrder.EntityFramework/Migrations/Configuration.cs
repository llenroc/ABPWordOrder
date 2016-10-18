using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using WorkOrder.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace WorkOrder.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<WorkOrder.EntityFramework.WorkOrderDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WorkOrder";
        }

        protected override void Seed(WorkOrder.EntityFramework.WorkOrderDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
