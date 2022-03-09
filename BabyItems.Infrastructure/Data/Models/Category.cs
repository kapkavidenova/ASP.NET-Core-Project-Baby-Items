using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static BabyItems.Infrastructure.DataConstants;

namespace BabyItems.Infrastructure.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryMaxLength)]
        public string Name { get; set; }

        public IEnumerable<Item> Items { get; set; } = new List<Item>();
    }
}
