using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyItems.Infrastructure.Data
{
    public class Trade
    {
        public int Id { get; set; }

        [Required]
        public int ContractorId { get; set; }

        public Contractor Contractor { get; set; }

        public IEnumerable<TradeStock> TradeStocks { get; set; }
    }
}
