using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class VeggieFaceContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<User> Users { get; set; }

        public VeggieFaceContext(DbContextOptions<VeggieFaceContext> options) : base(options)
            {

            }

    }
}
