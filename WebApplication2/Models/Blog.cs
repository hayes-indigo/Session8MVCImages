using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    [Display(Name="Veggies")]
    public class Blog
    {
        public int Id { get; set; }

        [Display(Name="Caption")]
        public string Text { get; set; }
        [Display(Name="Harvested On")]
        public DateTime PostedOn { get; set; }
    }

    public class BlogDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
    }
}
