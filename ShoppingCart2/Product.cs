namespace ShoppingCart2
{
    public class Product
    {
        public int Price { get; set; }
        public string ProductName { get; set; }

        public Product(int Price, string ProductName)
        {
            this.Price = Price;
            this.ProductName = ProductName;
        }
    }
}
