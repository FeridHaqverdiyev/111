using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Product>products { get; set; }
      
    }   }
