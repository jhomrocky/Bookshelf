using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key] //key is for ID, primary key
        public int ID { get; set; }
        [MinLength(2),MaxLength(50)] //minlength is for TITLE
        public string Title { get;set; }
        [Display(Name ="Published Date")] //inserting space into "Published Date" since var
                                          //cannot have spaces in name
        public DateTime PublishedDate { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string ISBN { get; set; }
        //use int/decimal/whatever for math mainly - use string ISBN here since no math

        [ForeignKey("Category")]
        public int CategoryID { get; set; } //this is public int ID from category.cs
        public virtual Category Category { get; set; }
    }
}