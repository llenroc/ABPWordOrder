using WorkOrder.EntityFramework;
using EntityFramework.DynamicFilters;

namespace WorkOrder.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly WorkOrderDbContext _context;

        public InitialHostDbBuilder(WorkOrderDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
