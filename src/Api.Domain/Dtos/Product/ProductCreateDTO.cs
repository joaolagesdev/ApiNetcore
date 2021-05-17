using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class ProductCreateDTO
    {
        [Required(ErrorMessage = "O nome do produto é campo obrigatório")]
        [StringLength(40, ErrorMessage = "O nome deve ter no máximo {1} caracteres")]
        public string Name { get; set; }
        
        [StringLength(100, ErrorMessage = "A descrição deve ter deve ter no máximo {1} caracteres")]
        public string Description { get; set; }
        
        [Range(0, int.MaxValue, ErrorMessage = "O preço informado é inválido")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "A quantidade informada é inválida")]
        public int Quantity { get; set; }
    }
}
