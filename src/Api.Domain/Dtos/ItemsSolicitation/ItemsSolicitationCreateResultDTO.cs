using Domain.Dtos.Product;
using System;

namespace Domain.Dtos.ItemsSolicitation
{
    public class ItemsSolicitationCreateResultDTO
    {
        public int QuantityItems { get; set; }
        public decimal TotalValue { get; set; }
        public decimal Discount { get; set; }
        public Guid ProductId { get; set; }
        public ProductDTO Product { get; set; }
    }
}
