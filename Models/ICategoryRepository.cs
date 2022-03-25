using System.Collections.Generic;

namespace SubnauticaMVC.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
