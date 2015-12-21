namespace Customer
{
    public class Payment
    {
        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName { get; set; }

        public decimal Price { get; set; }
    }
}