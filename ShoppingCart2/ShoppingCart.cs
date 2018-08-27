using System.Collections.Generic;

namespace ShoppingCart2
{
    public class ShoppingCart
    {
        public List<Product> MemberShoppingCart { get; set; }

        public void AddProduct(Product product)
        {
            MemberShoppingCart.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            MemberShoppingCart.Remove(product);
        }
    }
}
