using Microsoft.VisualBasic.CompilerServices;

namespace ACM.BL
{
    public class OrderItem
    {
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }
        
        public OrderItem()
        {
            
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public bool Validate()
        {
            bool isValid = !(Quantity <= 0);

            if (ProductId <= 0)
            {
                isValid = false;
            }

            if (PurchasePrice == null )
            {
                isValid = false;
            }

            return isValid;
        }
        
    }
}