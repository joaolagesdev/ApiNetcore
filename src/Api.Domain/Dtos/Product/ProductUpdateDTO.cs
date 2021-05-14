using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.Product
{
    public class ProductUpdateDTO
    {
        [Required(ErrorMessage = "O ID do produto é campo obrigatório")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é campo obrigatório")]
        [StringLength(40, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
        public string Description { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "O preço informado é inválido")]
        public decimal Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade informada é inválida")]
        public int Quantity { get; set; }
    }
}
