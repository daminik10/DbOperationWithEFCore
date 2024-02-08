using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DbOperationWithEFCore.Data
{
    public class AppDbContext :DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Language> Language { get; set; }
    }
}
