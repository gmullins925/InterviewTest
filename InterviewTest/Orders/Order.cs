using InterviewTest.Customers;
using InterviewTest.Products;
using System;
using System.Collections.Generic;

namespace InterviewTest.Orders
{
    public class Order : IOrder
    {
        public Order(string orderNumber, ICustomer buyer)
        {
            OrderNumber = orderNumber;
            Buyer = buyer;
            Products = new List<OrderedProduct>();
        }

        public string OrderNumber { get; private set; }
        public DateTime GetNow()
        {
            return DateTime.Now;
		}
        public ICustomer Buyer { get; private set; }
        public List<OrderedProduct> Products { get; private set; }

        public void AddProduct(IProduct product)
        {
            Products.Add(new OrderedProduct(product));
        }
    }
}
