using Microsoft.EntityFrameworkCore;
using NetCoreApp.Models;

namespace NetCoreApp.DbContextModels
{
    public class CatDb : DbContext
    {
        public CatDb(DbContextOptions<CatDb> options)
        : base(options) { }

        public DbSet<Cat> Todos => Set<Cat>();
    }
}
