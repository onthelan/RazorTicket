using System;
using System.Collections.Generic;

namespace RazorTicket.Models
{
    public class Subcategory
    {
        public int SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }
        public string SubcategoryDescription { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Ticket> Ticket { get; set; }
    }
}