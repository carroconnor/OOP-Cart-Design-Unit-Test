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

        Product basketball = new Product(10, "Basketball");
        Product sunglasses = new Product(20, "Sunglasses");
        Product shoes = new Product(30, "Shoes");
        Product umbrella = new Product(40, "Umbrella");
        Product flipflops = new Product(50, "Flip Flops");
    }
}
