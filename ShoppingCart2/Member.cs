using System;

namespace ShoppingCart2
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }

        public Member()
        {
            this.MemberID = MemberID;
            this.MemberName = MemberName;
        }

        public void BringMenu()
        {
            Console.WriteLine("1. Basketball for $10");
            Console.WriteLine("2. Sunglasses for $20");
            Console.WriteLine("3. Shoes for $30");
            Console.WriteLine("4. Umbrella for $40");
            Console.WriteLine("5. Flip Flops for $50");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter in the corresponding number to add item to your cart");
        }
    }
}
