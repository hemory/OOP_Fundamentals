using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public DateTime? OrderDate { get; set; } 
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public Order(): this(0)
        {
            
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        
        
        public bool Validate()
        {
            bool isValid = !(OrderDate == null);

            return isValid;
        }
    }
}