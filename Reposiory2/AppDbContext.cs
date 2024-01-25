using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Reposiory2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=FileCsv; Username=postgres; Password=12345678");
        }
        //Add the table in to database
        public DbSet<MarkReports> MarkReports { get; set; }
        //...add more if have or need
    }
}
