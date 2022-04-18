using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTracking.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string NameToken { get; set; }

        //[ForeignKey("CategoryTypeID")]
        //public virtual CategoryType CategoryType { get; set; }

        public int CategoryTypeID { get; set; }
        public CategoryType CategoryType { get; set; }

        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
