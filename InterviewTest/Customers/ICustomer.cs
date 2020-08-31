using InterviewTest.Orders;
using InterviewTest.Returns;
using System.Collections.Generic;

namespace InterviewTest.Customers
{
    public interface ICustomer
    {
        string GetName();
        void CreateOrder(IOrder order);
        void CreateReturn(IReturn rga);
        List<IOrder> GetOrders();
        List<IReturn> GetReturns();
        float GetTotalSales();
        float GetTotalReturns();
        float GetTotalProfit();
    }
}
