using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // This is the Customer class, representing a customer who may place orders.
    public class Customer
    {
        public int CustomerID { get; set; } // Unique identifier for a customer
        public string FirstName { get; set; } // First name of the customer
        public string LastName { get; set; } // Last name of the customer
        public string Country { get; set; } // Country where the customer is located
    }


    // This is the Order class, representing an order placed by a customer.
    public class Order
    {
        public int OrderID { get; set; } // Unique identifier for an order
        public int CustomerID { get; set; } // Identifier for the customer who placed the order
        public DateTime OrderDate { get; set; } // Date on which the order was placed
        public DateTime? ShippedDate { get; set; } // Date on which the order was shipped, nullable
    }


    // This is the Product class, representing a product that may be ordered.
    public class Product
    {
        public int ProductID { get; set; } // Unique identifier for a product
        public string ProductName { get; set; } // Name of the product
        public decimal UnitPrice { get; set; } // Price of a single unit of the product
    }


    // This is the OrderDetail class, representing a line item in an order.
    public class OrderDetail
    {
        public int OrderDetailID { get; set; } // Unique identifier for an order detail
        public int OrderID { get; set; } // Identifier for the order to which the detail belongs
        public int ProductID { get; set; } // Identifier for the product in the order detail
        public int Quantity { get; set; } // Number of units of the product ordered
        public decimal Discount { get; set; } // Discount applied to the product in the order detail
    }

    public class customerSummary
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public decimal AverageOrderAmount { get; set; }
        public decimal TotalAmountSpent { get; set; }
        public int NumberOfOrders { get; set; }

    }
}
