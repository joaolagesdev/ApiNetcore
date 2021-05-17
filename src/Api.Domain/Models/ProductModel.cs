using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ProductModel : BaseModel
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = string.IsNullOrEmpty(value) ? "S/N" : value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}