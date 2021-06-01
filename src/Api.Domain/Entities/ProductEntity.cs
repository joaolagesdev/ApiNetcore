using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<ItemsSolicitationEntity> ItemsSolicitation { get; set; }

        public void DebitQuantity(int quantity)
        {
            if (quantity < 0) quantity *= -1;
            Quantity -= quantity;
        }

        public void IncreaseQuantity(int quantity)
        {
            Quantity += quantity;
        }

        public bool HasQuantity(int quantity)
        {
            return Quantity >= quantity;
        }
    }
}
