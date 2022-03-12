using System.ComponentModel.DataAnnotations;
using static BabyItems.Infrastructure.DataConstants;

namespace BabyItems.Infrastructure.Data
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ItemNameMaxLength)]
        public string Name { get; set; }

        public int ForWeight { get; set; }

        [Required]
        [MaxLength(ItemDescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(ItemModelMaxLength)]
        public string Model { get; set; }

        public string? ImageUrl { get; set; }

        public string? Dimensions { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public IList<Cell> Cells { get; set; } = new List<Cell>();
    }
}
