using Microsoft.EntityFrameworkCore;
using MinimalAPIPosgreSQLEF.Models;

namespace MinimalAPIPosgreSQLEF.Data
{
    public class OfficeDb : DbContext
    {
        public OfficeDb(DbContextOptions<OfficeDb> options) : base(options) 
        {
            
        }
        public DbSet<Employee> Employees => Set<Employee>();
    }
}
