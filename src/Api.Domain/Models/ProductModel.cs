using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ProductModel
    {
        private Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }

        private int name;

        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
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

        private DateTime createdAt;

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value == null ? DateTime.UtcNow : value; }
        }
        
        private DateTime updateAt;
        public DateTime UpdateAt
        {
            get { return updateAt; }
            set { updateAt = value == null ? DateTime.UtcNow : value; }
        }
    }
}