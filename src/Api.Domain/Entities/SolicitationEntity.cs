using System.Collections.Generic;

namespace Domain.Entities
{
    public class SolicitationEntity
    {
        public decimal TotalValue { get; set; }
        public IEnumerable<ItemsSolicitationEntity> ItemsSolicitation { get; set; }
    }
}
