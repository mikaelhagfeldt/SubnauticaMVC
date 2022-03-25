namespace SubnauticaMVC.Models
{
    public class Fauna
    {

        // This comment to be deleted

        public int FaunaId { get; set; }
        public string Name { get; set; }
        public string GeneralInformation { get; set; }
        public string Appearance { get; set; }
        public string Behavior { get; set; }
        public decimal Health { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPoisonous { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
