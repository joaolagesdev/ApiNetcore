using System;


namespace Domain.Dtos
{
    public class ProductCreateResultDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
