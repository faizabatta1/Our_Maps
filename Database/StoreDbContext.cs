using Microsoft.EntityFrameworkCore;

namespace Our_Map_v2.Database
{
    public class StoreDbContext: DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {

        }

        public DbSet<Store> Stores { get; set; }
    }
}
