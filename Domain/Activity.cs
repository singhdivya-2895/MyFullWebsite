using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Activity
    {
        // This Annotation is required when you using custom attribute as your key.
        // For Example: MyId
        public Guid  Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}
