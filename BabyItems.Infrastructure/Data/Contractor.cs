
using System.ComponentModel.DataAnnotations;
using static BabyItems.Infrastructure.DataConstants;

namespace BabyItems.Infrastructure.Data
{
    public class Contractor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ContractorNameMaxLength)]
        public string Name { get; set; }

        [StringLength(ContractorIdentifierMaxLength)]
        public string? Identifier { get; set; }

        [StringLength(ContractorAddressMaxLength)]
        public string? Address { get; set; }

        [StringLength(20)]
        public string? Card { get; set; }

        public IEnumerable<Trade> Trades { get; set; } = new List<Trade>();
    }
}
