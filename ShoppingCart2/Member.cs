using System;

namespace ShoppingCart2
{
    public class Member
    {
        ShoppingCart cart = new ShoppingCart();
        public int MemberID { get; set; }
        public string MemberName { get; set; }

        public Member()
        {
            this.MemberID = MemberID;
            this.MemberName = MemberName;
        }

        public void Checkout()
        {
            double total = 0;

            foreach (var item in cart.MemberShoppingCart)
            {
                total += item.Price;
            }
            Console.WriteLine("Thankyou for shopping with us. Your subtotal is $ {0} ", total.ToString());
            if (this.MemberID == 0)
            {
                total = total * .15;
                Console.WriteLine("Thankyou for shopping with us. Your total after your membership discount is $ {0} ", total.ToString());
            }
        }

        public void BringMenu()
        {
            Console.WriteLine("1. Basketball for $10");
            Console.WriteLine("2. Sunglasses for $20");
            Console.WriteLine("3. Shoes for $30");
            Console.WriteLine("4. Umbrella for $40");
            Console.WriteLine("5. Flip Flops for $50");
            Console.WriteLine("6. View Cart");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter in the corresponding number to add item to your cart");
        }
    }
}
