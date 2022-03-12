using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using static BabyItems.Infrastructure.DataConstants;
namespace BabyItems.Infrastructure.Data
{
    public class Cell
    {
        public int Id { get; set; }

        [Required]
        [StringLength(CellNumberMaxLength)]
        public string Number { get; set; }

        [Required]
        [StringLength(CellSectionMaxLength)]
        public string Section { get; set; }

        [Required]
        public int ItemsCount { get; set; } = 0;

        public int ItemId { get; set; }

        public Item Item { get; set; }

    }
}
