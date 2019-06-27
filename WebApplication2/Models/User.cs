using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public class UserDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }

            public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
            {

            }
        }
    }
}
