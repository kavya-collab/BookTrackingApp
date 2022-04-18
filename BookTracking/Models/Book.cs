using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTracking.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        //[ForeignKey("CategoryID")]
        //public virtual Category Category { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
