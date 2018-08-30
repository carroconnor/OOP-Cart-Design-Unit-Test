using System;
using System.Collections.Generic;

namespace ShoppingCart2
{
    public class ShoppingCart
    {
        public List<Product> MemberShoppingCart = new List<Product>();

        public void AddProduct(Product product)
        {
            MemberShoppingCart.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            MemberShoppingCart.Remove(product);
        }

        public void ShowCart()
        {
            foreach (var item in MemberShoppingCart)
            {
                Console.WriteLine(item.ProductName);
            }
        }

        public void Checkout()
        {
            int total = 0;

            foreach (var item in MemberShoppingCart)
            {
                total += item.Price;
            }
            Console.WriteLine("Thankyou for shopping with us. Your subtotal is $ {0} ", total.ToString());
        }
    }
}
