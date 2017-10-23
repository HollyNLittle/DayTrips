using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Review> Review { get; set; }

    }
}