using System.ComponentModel.DataAnnotations;

namespace ContosoRecipies.Models
{
    public class Recipie
    {
        public string Title { get; init; }
        public string Description { get; init; }
        public IEnumerable<string> Directions { get; init; }
        public IEnumerable<string> Tags { get; init; }

        [Required]
        public IEnumerable<Ingrediant> Ingrediants { get; init; }
        public DateTime Updated { get; init; }
    }

    public record Ingrediant
    {
        [Required]
        public string Name { get; init; }
        public string Amount { get; init; }
        public string Unit { get; init; }
    }
}
