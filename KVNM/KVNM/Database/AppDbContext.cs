using KVNM.Models;
using KVNM.Models.VillaDto;
using Microsoft.EntityFrameworkCore;

namespace KVNM.Database
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        
        {

        }
        public DbSet<Villa> villaDtos { get; set; }
    }
}
