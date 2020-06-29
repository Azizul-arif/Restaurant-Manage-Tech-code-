using RestManage.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace RestManage.Data
{
    public class AppDbContext: DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Employee> Employees { get; set; }
    }
}