using Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.ItemsSolicitation
{
    public class ItemsSolicitationCreateDTO
    {
        [Required(ErrorMessage = "A quantidade do produto é campo obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade informada é inválida")]
        public int QuantityItems { get; set; }
        // public decimal TotalValue { get; set; }
        // public Guid ProductId { get; set; }
        // public Guid SolicitationId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
