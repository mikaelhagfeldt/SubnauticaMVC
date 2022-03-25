using System.Collections.Generic;

namespace SubnauticaMVC.Models
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Carnivores", CategoryDescription = "A carnivore, or meat-eater, is an animal whose food and energy requirements derive solely from animal tissues whether through hunting or scavenging." },
                new Category { CategoryId = 2, CategoryName = "Herbivores", CategoryDescription = "A herbivore is an animal anatomically and physiologically adapted to eating plant material, for example foliage or marine algae, for the main component of its diet. As a result of their plant diet, herbivorous animals typically have mouthparts adapted to rasping or grinding." }
            };
    }
}
