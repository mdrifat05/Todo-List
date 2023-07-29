using CRUD.NetCoreAngularjs.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.NetCoreAngularjs.Database
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
