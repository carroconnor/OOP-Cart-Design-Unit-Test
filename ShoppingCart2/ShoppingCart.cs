using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart2
{
    public class ShoppingCart
    {
        public List<Product> MemberShoppingCart = new List<Product>();

        public void AddProduct(Product product)
        {
            MemberShoppingCart.Add(product);
        }

        public void DeleteProduct(string deleteProductChoice)
        {
            foreach (var item in MemberShoppingCart.Select((value, i) => new { i, value }).ToList())
            {
                var value = item.value;
                var index = item.i;
                if (index.ToString() == deleteProductChoice)
                {
                    MemberShoppingCart.Remove(item.value);
                }
            }
            Console.WriteLine("Item Deleted");
        }

        public void ShowCart()
        {
            foreach (var item in MemberShoppingCart.Select((value, i) => new { i, value }))
            {
                var value = item.value;
                var index = item.i;
                Console.WriteLine(item.i + " " + value.ProductName);
            }
        }

        public void Checkout(object currentUser)
        {
            double total = 0;

            foreach (var item in MemberShoppingCart)
            {
                total += item.Price;
            }
            Console.WriteLine("Thankyou for shopping with us. Your subtotal is $ {0} ", total.ToString());
            BronzeMember cali = new BronzeMember(04, "Cali OConnor");
            SilverMember caroline = new SilverMember(03, "Caroline OConnor");
            SilverMember kevin = new SilverMember(02, "Kevin OConnor");
            GoldMember carr = new GoldMember(01, "Carr OConnor");
            if (currentUser.ToString() == carr.ToString())
            {
                total = total - (total * .15);
                Console.WriteLine("Thankyou for shopping with us. Your total after your membership discount is $ {0} ", total.ToString());
            }
            else if (currentUser.ToString() == cali.ToString())
            {
                total = total - (total * 1);
                Console.WriteLine("Thankyou for shopping with us. Your total after your membership discount is $ {0} ", total.ToString());
            }
            else if (currentUser.ToString() == caroline.ToString())
            {
                total = total - (total * .1);
                Console.WriteLine("Thankyou for shopping with us. Your total after your membership discount is $ {0} ", total.ToString());
            }
            else if (currentUser.ToString() == kevin.ToString())
            {
                total = total - (total * .1);
                Console.WriteLine("Thankyou for shopping with us. Your total after your membership discount is $ {0} ", total.ToString());
            }
        }
    }
}
