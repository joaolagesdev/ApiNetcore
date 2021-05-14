using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SolicitationEntity
    {
        [MaxLength(40)]
        public string Client { get; set; }
        public decimal TotalValue { get; set; }
        public IEnumerable<ItemsSolicitationEntity> ItemsSolicitation { get; set; }
    }
}
