using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookTracking.Models
{
    public class CategoryType
    {
        [Key]
        public int CategoryTypeID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }

    }
}
