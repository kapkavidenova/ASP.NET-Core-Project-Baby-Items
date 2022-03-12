using System.ComponentModel.DataAnnotations;

using static BabyItems.Infrastructure.DataConstants;

namespace BabyItems.Infrastructure.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; }


        [MaxLength(CategoryDescriptionMaxLength)]
        public string? Description { get; set; }

        public IEnumerable<Item> Items { get; set; } = new List<Item>();
    }
}
