using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyItems.Infrastructure.Data
{
    public class TradeStock
    {
        public int Id { get; set; }

        [Required]
        public int TradeId { get; set; }

        public Trade Trade { get; set; }

        [Required]
        public int ItemId { get; set; }

        public Item Item { get; set; }

        public int ItemCount { get; set; }
    }
}
