using Domain.Dtos.Product;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.ItemsSolicitation
{
    public class ItemsSolicitationCreateDTO
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade informada é inválida")]
        public int Quantity { get; set; }
        [Required]
        public Guid ProductId { get; set; }
    }
}
