using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec25_Assign53_Customers_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define a list of customers
            List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerID = 1, FirstName = "John", LastName = "Doe", Country = "USA" },
            new Customer { CustomerID = 2, FirstName = "Jane", LastName = "Doe", Country = "USA" },
            new Customer { CustomerID = 3, FirstName = "Alice", LastName = "Smith", Country = "Canada" },
            new Customer { CustomerID = 4, FirstName = "Bob", LastName = "Smith", Country = "Canada" },
            new Customer { CustomerID = 5, FirstName = "Charlie", LastName = "Brown", Country = "USA" }
        };

            // Create some sample products
            List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Chai", UnitPrice = 18.00M },
            new Product { ProductID = 2, ProductName = "Chang", UnitPrice = 19.00M },
            new Product { ProductID = 3, ProductName = "Aniseed Syrup", UnitPrice = 10.00M },
            new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", UnitPrice = 22.00M },
            new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", UnitPrice = 21.35M },
            new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", UnitPrice = 25.00M },
            new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", UnitPrice = 30.00M },
            new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", UnitPrice = 40.00M },
            new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", UnitPrice = 97.00M },
            new Product { ProductID = 10, ProductName = "Ikura", UnitPrice = 31.00M },
            new Product { ProductID = 11, ProductName = "Queso Cabrales", UnitPrice = 21.00M },
            new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", UnitPrice = 38.00M },
            new Product { ProductID = 13, ProductName = "Konbu", UnitPrice = 6.00M },
            new Product { ProductID = 14, ProductName = "Tofu", UnitPrice = 23.25M },
            new Product { ProductID = 15, ProductName = "Genen Shouyu", UnitPrice = 15.50M }
        };

            // define a list of orders
            List<Order> orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerID = 1, OrderDate = new DateTime(2022, 1, 1), ShippedDate = new DateTime(2022, 1, 10) },
                new Order { OrderID = 2, CustomerID = 1, OrderDate = new DateTime(2022, 2, 1), ShippedDate = new DateTime(2022, 2, 10) },
                new Order { OrderID = 3, CustomerID = 2, OrderDate = new DateTime(2022, 3, 1), ShippedDate = new DateTime(2022, 3, 10) },
                new Order { OrderID = 4, CustomerID = 3, OrderDate = new DateTime(2022, 4, 1), ShippedDate = new DateTime(2022, 4, 10) },
                new Order { OrderID = 5, CustomerID = 4, OrderDate = new DateTime(2022, 5, 1), ShippedDate = new DateTime(2022, 5, 10) },
                new Order { OrderID = 6, CustomerID = 5, OrderDate = new DateTime(2022, 6, 1), ShippedDate = new DateTime(2022, 6, 10) },
                new Order { OrderID = 7, CustomerID = 1, OrderDate = new DateTime(2022, 7, 1), ShippedDate = new DateTime(2022, 7, 10) },
                new Order { OrderID = 8, CustomerID = 2, OrderDate = new DateTime(2022, 8, 1), ShippedDate = new DateTime(2022, 8, 10) },
                new Order { OrderID = 9, CustomerID = 3, OrderDate = new DateTime(2022, 9, 1), ShippedDate = new DateTime(2022, 9, 10) },
                new Order { OrderID = 10, CustomerID = 4, OrderDate = new DateTime(2022, 10, 1), ShippedDate = new DateTime(2022, 10, 10) }
                };

            // define a list of order details
            List<OrderDetail> orderDetails = new List<OrderDetail>()
            {
                new OrderDetail() { OrderDetailID = 1, OrderID = 1, ProductID = 1, Quantity = 5, Discount = 0.1m },
                new OrderDetail() { OrderDetailID = 2, OrderID = 1, ProductID = 2, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 3, OrderID = 2, ProductID = 3, Quantity = 2, Discount = 0.05m },
                new OrderDetail() { OrderDetailID = 4, OrderID = 2, ProductID = 4, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 5, OrderID = 3, ProductID = 5, Quantity = 4, Discount = 0m },
                new OrderDetail() { OrderDetailID = 6, OrderID = 4, ProductID = 6, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 7, OrderID = 4, ProductID = 7, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 8, OrderID = 5, ProductID = 8, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 9, OrderID = 5, ProductID = 9, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 10, OrderID = 5, ProductID = 10, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 11, OrderID = 6, ProductID = 1, Quantity = 4, Discount = 0m },
                new OrderDetail() { OrderDetailID = 12, OrderID = 7, ProductID = 2, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 13, OrderID = 7, ProductID = 3, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 14, OrderID = 7, ProductID = 4, Quantity = 3, Discount = 0.1m },
                new OrderDetail() { OrderDetailID = 15, OrderID = 8, ProductID = 5, Quantity = 7, Discount = 0m },
                new OrderDetail() { OrderDetailID = 16, OrderID = 8, ProductID = 6, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 17, OrderID = 9, ProductID = 7, Quantity = 2, Discount = 0m },
                new OrderDetail() { OrderDetailID = 18, OrderID = 10, ProductID = 8, Quantity = 3, Discount = 0m },
                new OrderDetail() { OrderDetailID = 19, OrderID = 10, ProductID = 9, Quantity = 1, Discount = 0m },
                new OrderDetail() { OrderDetailID = 20, OrderID = 10, ProductID = 10, Quantity = 4, Discount = 0m }
            };
            Console.WriteLine("a. All customers in alphabetical order by last name: ");
            customers.OrderBy(a => a.LastName).ToList().ForEach(a => Console.WriteLine(a.FirstName + " " + a.LastName));
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("b. All products in order of unit price, from highest to lowest: ");
            products.OrderByDescending(a => a.UnitPrice).ToList().ForEach(a => Console.WriteLine(a.ProductName + ": " + a.UnitPrice));
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("c. All orders that were shipped in October 2021: ");
            var newList = orders.FindAll(s => s.OrderDate.Year == 2021 && s.OrderDate.Month == 10);
            foreach (var item in newList)
            {  
                Console.WriteLine("Order ID: " + item.OrderID + ", shipped in of orders shipped in October 2021 "); 
            }
            Console.WriteLine("------------------------------------------------------------");


            Console.WriteLine("d. All orders that were shipped to customers in the USA.: ");
            var aList = customers.FindAll(s => s.Country == "USA");
            foreach (var a in aList)
            {
                foreach (var item in orders) //var a in aList
                {
                    if (item.CustomerID == a.CustomerID)
                    { 
                        Console.WriteLine("Order " + item.OrderID + " shipped to " + a.Country);
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("e. All products that were ordered at least once, along with the total quantity ordered and the total revenue generated by each product.: ");

            var cList = orderDetails.GroupBy(a => a.ProductID).ToList(); //.ForEach(a => Console.WriteLine("Product ID: " + a.));
            foreach (var c in cList)
            {
                //Console.WriteLine(c.First().ProductID + ", Count: " + c.Count());
                Console.WriteLine("Product Name: " + products.Find(b => b.ProductID == c.First().ProductID).ProductName);
                int quantitySum = 0;
                foreach (var obj in c) 
                {
                    quantitySum = quantitySum + obj.Quantity;
                }
                Console.WriteLine("Total quantity ordered: " + quantitySum);

                decimal revenue = 0;
                revenue = quantitySum * products.Find(e => e.ProductID == c.First().ProductID).UnitPrice;
                Console.WriteLine("Total revenue generated: " + revenue + "\n");

            }
            
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("f. The top 5 customers by the total amount of money they have spent, along with the number of orders they have placed and the average order amount.: ");

            var query6 = customers
      .Join(
          orders,
          customer => customer.CustomerID,
          order => order.CustomerID,
          (customer, order) => new { customer, order }
      )
      .Join(
          orderDetails,
          c => c.order.OrderID,
          orderDetail => orderDetail.OrderID,
          (c, orderDetail) => new { c.customer, c.order, orderDetail }
      )
      .Join(
          products,
          c => c.orderDetail.ProductID,
          product => product.ProductID,
          (c, product) => new { c.customer, c.order, c.orderDetail, product }
      )
      .GroupBy(
          c => c.customer,
          c => c,
          (customer, orderProducts) => new
          {
              Customer = customer,
              TotalAmountSpent = orderProducts.Sum(x => (x.orderDetail.Quantity * x.product.UnitPrice) * (1 - x.orderDetail.Discount)),
              NumberOfOrders = orderProducts.Select(x => x.order.OrderID).Distinct().Count(),
              AverageOrderAmount = orderProducts.Sum(x => (x.orderDetail.Quantity * x.product.UnitPrice) * (1 - x.orderDetail.Discount)) / orderProducts.Select(x => x.order.OrderID).Distinct().Count()
          }
      )
      .OrderByDescending(c => c.TotalAmountSpent)
      .Take(5);
    
            foreach (var customer in query6)
            {
                Console.WriteLine($"{customer.Customer.FirstName} {customer.Customer.LastName}: Total Amount Spent: {customer.TotalAmountSpent:C}, Number of Orders: {customer.NumberOfOrders}, Average Order Amount: {customer.AverageOrderAmount:C}");
            }



            /*
           List<customerSummary> customerSummaries = new List<customerSummary>();
           customerSummary tempCustomerSummary;
           var gList = orders.GroupBy(a => a.CustomerID).ToList();
           Console.WriteLine("Order List Count:" + gList.Count() );
           foreach (var g in gList)
           {
               tempCustomerSummary = new customerSummary();
               tempCustomerSummary.CustomerID = g.First().CustomerID;
               tempCustomerSummary.CustomerName = customers.Find(a => a.CustomerID == g.First().CustomerID).FirstName;
               tempCustomerSummary.TotalAmountSpent = 0;
               tempCustomerSummary.AverageOrderAmount = 0;
               Console.WriteLine("Order Count: " + g.Count() + " for Customer ID: " + g.First().CustomerID);
               foreach (var obj in g)
               {
                   Console.WriteLine("Order ID: " + obj.OrderID + " for Customer: " + obj.CustomerID);
                   var hList = orderDetails.GroupBy(a => a.OrderID == obj.OrderID).ToList();
                   Console.WriteLine("orderDetails List Count:" + hList.Count());
                   decimal totalOrderPrice = 0;
                   foreach (var h in hList)
                   {
                       h.First().
                       foreach (var objOrderDetail in h)
                       {
                           totalOrderPrice = totalOrderPrice + objOrderDetail.Quantity * products.Find(a => a.ProductID == objOrderDetail.ProductID).UnitPrice;
                           Console.WriteLine("Quantity: " + objOrderDetail.Quantity + ", UnitPrice: " + products.Find(a => a.ProductID == objOrderDetail.ProductID).UnitPrice + "Object Detail Order ID: " + objOrderDetail.OrderID);
                       }
                       tempCustomerSummary.TotalAmountSpent = tempCustomerSummary.TotalAmountSpent + totalOrderPrice;
                       tempCustomerSummary.NumberOfOrders = tempCustomerSummary.NumberOfOrders +1;
                       Console.WriteLine("OrderID: " + h.First().OrderID + " " + tempCustomerSummary.TotalAmountSpent + " " + tempCustomerSummary.NumberOfOrders);

                   }
                   tempCustomerSummary.AverageOrderAmount = tempCustomerSummary.TotalAmountSpent / tempCustomerSummary.NumberOfOrders;
                   customerSummaries.Add(tempCustomerSummary);
                   Console.WriteLine("AverageOrderAmount: "+ tempCustomerSummary.AverageOrderAmount);
               }

           }
           var jlist = customerSummaries.OrderByDescending(x => x.TotalAmountSpent);
           foreach (var j in jlist)
           {
               Console.WriteLine(j.CustomerName + ", " + j.TotalAmountSpent + ", " + j.AverageOrderAmount + ", " + j.NumberOfOrders);
           }
          
           */
            Console.WriteLine("\n------------------------------------------------------------");
            Console.WriteLine("g. The most popular product by the number of times it has been ordered.: ");
            

            var eList = orderDetails.GroupBy(a => a.ProductID).ToList();
            int maxProductID = 0; 
            decimal maxQuantity = 0;

            foreach (var e in eList)
            {
                decimal sum = 0;
                foreach (var obj in e)
                {
                    sum = sum + obj.Quantity;
                }
                if (sum > maxQuantity)
                {
                    maxQuantity = sum;
                    maxProductID = e.First().ProductID;
                }
            }
            //Console.WriteLine(maxQuantity + " " + maxProductID);
            Console.WriteLine("The most popular product is " + products.Find(b => b.ProductID == maxProductID).ProductName + ", which has been ordered " + maxQuantity + " times.");
            Console.ReadKey();


        }
    }
}
