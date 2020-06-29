using Microsoft.EntityFrameworkCore;
using RestManage.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace RestManage.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}