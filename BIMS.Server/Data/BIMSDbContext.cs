using BIMS.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BIMS.Server.Data
{
    public class BIMSDbContext : DbContext
    {
        public BIMSDbContext(DbContextOptions<BIMSDbContext> options)
       : base(options)
        {
        }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Purchase>  Purchases  { get; set; }
        public DbSet<Sale>  Sales { get; set; }
    }
}
