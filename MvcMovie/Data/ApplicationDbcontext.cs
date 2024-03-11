using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;


namespace MvcMovie.Data 
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person {get; set;}
    }
}