using InterviewTest.Orders;
using System.Collections.Generic;

namespace InterviewTest.Returns
{
    public class Return : IReturn
    {
        public Return(string returnNumber, IOrder originalOrder)
        {
            ReturnNumber = returnNumber;
            OriginalOrder = originalOrder;
            ReturnedProducts = new List<ReturnedProduct>();
        }

        public string ReturnNumber { get; private set; }
        public IOrder OriginalOrder { get; private set; }
        public List<ReturnedProduct> ReturnedProducts { get; private set; }

        public void AddProduct(OrderedProduct product)
        {
            ReturnedProducts.Add(new ReturnedProduct(product));
        }
    }
}
