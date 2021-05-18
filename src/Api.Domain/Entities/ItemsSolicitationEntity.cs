
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ItemsSolicitationEntity : BaseEntity
    {
        public int Quantity { get; set; }
        [Required]
        public decimal TotalValue { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public Guid ItemsSolicitationId { get; set; }
        public ProductEntity Product { get; set; }
        public SolicitationEntity Solicitation { get; set; }

        // 2 TABELAS - PRODUTO E ITENS
    }
}
