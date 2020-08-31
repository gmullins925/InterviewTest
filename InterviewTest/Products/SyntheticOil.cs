namespace InterviewTest.Products
{
    public class SyntheticOil : IProduct
    {
        public float GetCost()
        {
            return 25;
        }

        public string GetProductNumber()
        {
            return "Mobil 1 5W-30";
        }
    }
}
