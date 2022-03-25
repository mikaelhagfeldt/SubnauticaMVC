using System.Collections.Generic;

namespace SubnauticaMVC.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public List<Category> Categories { get; set; }
    }
}
