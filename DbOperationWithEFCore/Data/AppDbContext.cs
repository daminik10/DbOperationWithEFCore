using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCore.Data
{
    public class AppDbContext :DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }
    }
}
