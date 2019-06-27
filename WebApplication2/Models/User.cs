using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
