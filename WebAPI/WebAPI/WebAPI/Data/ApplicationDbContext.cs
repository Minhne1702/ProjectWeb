using System.Collections.Generic;
using Lab09.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab09.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}