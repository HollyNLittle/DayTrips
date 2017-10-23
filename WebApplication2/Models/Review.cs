using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }


        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}