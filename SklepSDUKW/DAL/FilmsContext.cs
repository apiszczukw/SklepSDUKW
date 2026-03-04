using Microsoft.EntityFrameworkCore;
using SklepSDUKW.Models;

namespace SklepSDUKW.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<Category> Categories { get; set; }

        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }
    }
}
