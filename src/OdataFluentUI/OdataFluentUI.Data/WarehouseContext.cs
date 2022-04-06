using Microsoft.EntityFrameworkCore;

namespace OdataFluentUI.Data
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext()
        {

        }

        public WarehouseContext(DbContextOptions<WarehouseContext> options)
           : base(options)
        {
        }

        public DbSet<Material> Materials { get; set; }
    }
}
