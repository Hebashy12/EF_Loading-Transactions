using EF_Task2.DAL.Entities;
using Microsoft.EntityFrameworkCore;




namespace EF_Task2.DAL.Database
{
    public class AplicationDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.;Initial Catalog=EF_Task2;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Department { get; set; }


    }
}
