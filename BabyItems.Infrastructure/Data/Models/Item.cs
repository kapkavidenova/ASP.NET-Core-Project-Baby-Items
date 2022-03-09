using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static BabyItems.Infrastructure.DataConstants;

namespace BabyItems.Infrastructure.Data.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public int ForWeight { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string Dimensions { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
