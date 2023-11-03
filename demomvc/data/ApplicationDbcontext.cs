using Microsoft.EntityFrameworkCore;
using demomvc.Models;

namespace demomvc.data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {}
        public DbSet<Person> Person { get;set;}
    }

   
    
    }
