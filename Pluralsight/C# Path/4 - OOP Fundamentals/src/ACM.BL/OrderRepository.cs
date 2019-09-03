using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderRepository
    {
         public Order Retrive(int orderId)
        {
            return new Order();            
        }

        public List<Order> Retrive()
        {
            return new List<Order>();
        } 

        public bool Save(Order entity)
        {
            var success = entity.IsValid;

            if(entity.IsValid && entity.HasChanges)
            {
                if(entity.IsValid)
                {
                    // Call an insert stored procedure
                }
                else 
                {
                    // Call an update stored procedure
                }
            }

            return success;
        }
    }
}