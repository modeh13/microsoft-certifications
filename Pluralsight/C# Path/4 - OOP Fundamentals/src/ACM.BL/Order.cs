using System;
using System.Collections.Generic;
using ACM.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public int OrderId { get; set; }

        // Composition relationship (has a) 1-1, 1-N, N-N
        // Using identifier of reference data
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public int ShippingAddressId { get; set; }
        public Address ShippingAddres { get; set; }

        // Composition using a property reference
        public List<OrderItem> OrderItems { get; set; }

        public Order() : this(0)
        {            
        }

        public Order(int orderId)
        {            
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public override bool Validate()
        {
            return true;
        }

        public override string ToString() => $"{OrderDate}-{OrderId}";

        public string Log() => $"{OrderDate}-{OrderId}";
    }
}