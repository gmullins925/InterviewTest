using InterviewTest.Customers;
using InterviewTest.Orders;
using InterviewTest.Products;
using InterviewTest.Returns;
using System;
using System.Linq;

namespace InterviewTest
{
    public class Program
    {
        private static readonly OrderRepository orderRepo = new OrderRepository();
        private static readonly ReturnRepository returnRepo = new ReturnRepository();

		static void Main(string[] args)
        {
            ProcessTruckAccessoriesExample();
            ProcessCarDealershipExample();

            //Logic changes
            //Q: Record when an item was purchased.
            //Q: Implement get total sales, returns, and profit in the CustomerBase class.

            //Bug fixes
            //Q: The Truck Accessories Customer's returns are not being processed.
            //Q: The Car Dealership Customer's totals are incorrect.
         
            Console.ReadKey();
        }

        private static void ProcessTruckAccessoriesExample()
        {
            ICustomer customer = GetTruckAccessoriesCustomer();

            IOrder order = new Order("Order1", customer);
            order.AddProduct(new HitchAdapter());
            order.AddProduct(new BedLiner());
            customer.CreateOrder(order);

            IReturn rga = new Return("Return1", order);
            rga.AddProduct(order.Products.First());

            ConsoleWriteLineResults(customer);
        }

        private static void ProcessCarDealershipExample()
        { 
            ICustomer customer = GetCarDealershipCustomer();

            IOrder order = new Order("Order2", customer);
            order.AddProduct(new ReplacementBumper());
            order.AddProduct(new SyntheticOil());
            customer.CreateOrder(order);

            IReturn rga = new Return("Return2", order);
            rga.AddProduct(order.Products.First());
            customer.CreateReturn(rga);

            ConsoleWriteLineResults(customer);
        }

        private static ICustomer GetTruckAccessoriesCustomer()
        {
            return new TruckAccessoriesCustomer(orderRepo, returnRepo);
        }

        private static ICustomer GetCarDealershipCustomer()
        {
            return new CarDealershipCustomer(orderRepo, returnRepo);
        }

        private static void ConsoleWriteLineResults(ICustomer customer)
        {
            Console.WriteLine(customer.GetName());

            Console.WriteLine($"Total Sales: {customer.GetTotalSales().ToString("c")}");

            Console.WriteLine($"Total Returns: {customer.GetTotalReturns().ToString("c")}");

            Console.WriteLine($"Total Profit: {customer.GetTotalProfit().ToString("c")}");

            Console.WriteLine();
        }
    }
}
