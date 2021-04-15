using System;
using System.Collections.Generic;

namespace RazorTicket.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<Subcategory> Subcategory { get; set; }

        public List<Ticket> Ticket { get; set; }
    }
}