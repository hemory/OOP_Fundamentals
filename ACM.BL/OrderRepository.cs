using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 1)
            {
                order.OrderDate = Convert.ToDateTime("04/14/2021 17:07:25 -04:00");
            }
            return order;
        }


        public bool Save(Order order)
        {
            return true;
        }
    }
}