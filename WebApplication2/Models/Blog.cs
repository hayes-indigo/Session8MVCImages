using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Display(Name="Caption")]
        public string Text { get; set; }
        [Display(Name="Harvested On")]
        public DateTime PostedOn { get; set; }

        [Display(Name="Picture")]
        public byte[] Image { get; set; }

        public int UserId { get; set; }
        public string FilterName { get; set; }
    }
}
