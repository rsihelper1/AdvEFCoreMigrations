
using Microsoft.EntityFrameworkCore;
using AdvEFCoreMigrations.Models;

    namespace AdvEFCoreMigrations.Context
{
    public class MyCompanyDBContext : DbContext
    {
        public MyCompanyDBContext(DbContextOptions<MyCompanyDBContext> options) : base (options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
