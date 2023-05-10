using System.Linq;
using BoilerPlate.EntityFramework;
using BoilerPlate.MultiTenancy;

namespace BoilerPlate.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly BoilerPlateDbContext _context;

        public DefaultTenantCreator(BoilerPlateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
