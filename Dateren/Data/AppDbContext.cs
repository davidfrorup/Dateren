using Dateren.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dateren.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


    }
}
