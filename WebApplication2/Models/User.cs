using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
