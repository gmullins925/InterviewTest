using System;
using System.Collections.Generic;
using InterviewTest.Customers;
using InterviewTest.Products;

namespace InterviewTest.Orders
{
    public interface IOrder
    {
        ICustomer Buyer { get; }
        string OrderNumber { get; }
        DateTime GetNow();
        List<OrderedProduct> Products { get; }

        void AddProduct(Products.IProduct product);
    }
}