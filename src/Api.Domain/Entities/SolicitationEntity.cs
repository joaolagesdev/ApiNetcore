using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SolicitationEntity : BaseEntity
    {
        [Required]
        public decimal TotalValue { get; set; }
        public decimal Shipping { get; set; }
        public IEnumerable<ItemsSolicitationEntity> ItemsSolicitation { get; set; }
    }
}
