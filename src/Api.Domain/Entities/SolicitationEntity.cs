
namespace Domain.Entities
{
    public class SolicitationEntity : BaseEntity
    {
        public string Client { get; set; }

        private decimal solicitationValue;
        public decimal SolicitationValue
        {
            get { return solicitationValue; }
            set { solicitationValue = SolicitationValue; }
        }

        public char situation; // Enum
    }
}
