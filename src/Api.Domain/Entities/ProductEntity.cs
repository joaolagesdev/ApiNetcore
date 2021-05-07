using System;

namespace Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = Price; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = Quantity; }
        }
    }
}
