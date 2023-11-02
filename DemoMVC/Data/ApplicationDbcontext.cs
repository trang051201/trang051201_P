using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

namespace MvcMovie.ViewData
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options) : base(options)
        {}
        public DbSet <Person> Person { get; set; }
    }
}
