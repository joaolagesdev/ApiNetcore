using Domain.Entities;
using System;

namespace Domain.Dtos.ItemsSolicitation
{
    public class ItemsSolicitationDTO
    {
        public Guid Id { get; set; }
        public int QuantityItems { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalValue { get; set; }
        public ProductEntity Product { get; set; }
    }
}
