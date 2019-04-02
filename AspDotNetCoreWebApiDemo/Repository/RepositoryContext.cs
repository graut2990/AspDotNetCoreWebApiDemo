
using Microsoft.EntityFrameworkCore;

public class DBRepositoryContext :DbContext
{
   public DBRepositoryContext(DbContextOptions options) 
            :base(options)
        {
        } 
        public DbSet<Employee> Employees { get; set; }
}