using System;

namespace RazorTicket.Models
{
    public class Subcategory
    {
        public int SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }
        public string SubcategoryDescription { get; set; }

        public Category Category { get; set; }
    }
}