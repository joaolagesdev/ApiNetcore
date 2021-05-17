using Domain.Dtos.Product;
using System;

namespace Domain.Dtos.ItemsSolicitation
{
    public class ItemsSolicitationDTO
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalValue { get; set; }
        public Guid ProductId { get; set; }
        public Guid SolicitationId { get; set; }
        public ProductDTO Product { get; set; }
    }
}
