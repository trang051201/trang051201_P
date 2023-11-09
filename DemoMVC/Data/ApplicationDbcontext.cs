using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set;}
        public DbSet<DemoMVC.Models.Employee> Employee { get; set; } = default!;
// khai báo việc ánh xạ class Person vào trong database
    }
}