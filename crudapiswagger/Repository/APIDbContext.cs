using Microsoft.EntityFrameworkCore;
using crudapiswagger.Models;


namespace crudapiswagger.Repository
{
    public class APIDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
