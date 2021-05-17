using System;

namespace Domain.Models
{
    public class ItemsSolicitationModel : BaseModel
    {
        private decimal quantity;
        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private decimal discount;
        public decimal Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        //Atualizar valor total
        private decimal totalValue;
        public decimal TotalValue
        {
            get { return totalValue; }
            set { totalValue = value; }
        }

        private Guid productId;
        public Guid ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private Guid solicitationId;
        public Guid SolicitationId
        {
            get { return solicitationId; }
            set { solicitationId = value; }
        }
    }
}
