using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class ProductDTO
    {
        [Required(ErrorMessage = "O nome do produto é campo obrigatório")]
        [StringLength(40, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
        public string Name { get; set; }
        
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
