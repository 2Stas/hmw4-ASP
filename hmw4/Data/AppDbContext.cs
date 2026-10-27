using AutoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context): base(context){}

        public DbSet<Auto> Autos { get; set; }
    }
}