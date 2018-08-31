using System;

namespace ShoppingCart2
{
    class Program
    {
        static void Main(string[] args)
        {
            object currentUser;
            ShoppingCart cart = new ShoppingCart();
            Product basketball = new Product(10, "Basketball");
            Product sunglasses = new Product(20, "Sunglasses");
            Product shoes = new Product(30, "Shoes");
            Product umbrella = new Product(40, "Umbrella");
            Product flipflops = new Product(50, "Flip Flops");

            do
            {
                Console.WriteLine("Welcome to the store");
                Console.WriteLine("Please enter your Member Name");
                var MemId = Console.ReadLine();


                if (MemId == "Carr OConnor")
                {
                    GoldMember carr = new GoldMember(01, "Carr O'Connor");
                    currentUser = carr;
                    Console.WriteLine("Welcome Carr. Thank you for being a gold member with us. Below is a list of our products.");
                    carr.BringMenu();
                    break;
                }
                else if (MemId == "Kevin OConnor")
                {
                    SilverMember kevin = new SilverMember(02, "Kevin OConnor");
                    currentUser = kevin;
                    Console.WriteLine("Welcome Kevin. Thank you for being a silver member with us. Below is a list of our products.");
                    kevin.BringMenu();
                    break;
                }
                else if (MemId == "Caroline OConnor")
                {
                    SilverMember caroline = new SilverMember(03, "Caroline OConnor");
                    currentUser = caroline;
                    Console.WriteLine("Welcome Caroline. Thank you for being a silver member with us. Below is a list of our products.");
                    caroline.BringMenu();
                    break;
                }
                else if (MemId == "Cali OConnor")
                {
                    BronzeMember cali = new BronzeMember(04, "Cali OConnor");
                    currentUser = cali;
                    Console.WriteLine("Welcome Caroline. Thank you for being a silver member with us. Below is a list of our products.");
                    cali.BringMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("That does look like a registered member. Lets try that again");
                }

            } while (true);

            Start:
            do
            {
                var productChoice = Console.ReadLine();
                if (productChoice == "1")
                {
                    cart.AddProduct(basketball);
                    break;
                }
                else if (productChoice == "2")
                {
                    cart.AddProduct(sunglasses);
                    break;
                }
                else if (productChoice == "3")
                {
                    cart.AddProduct(shoes);
                    break;
                }
                else if (productChoice == "4")
                {
                    cart.AddProduct(umbrella);
                    break;
                }
                else if (productChoice == "5")
                {
                    cart.AddProduct(flipflops);
                    break;
                }
                else if (productChoice == "6")
                {
                    cart.ShowCart();
                }
                else
                {
                    Member member = new Member();
                    Console.WriteLine("That does not look like a valid product. Try again");
                    member.BringMenu();
                }
            } while (true);

            Back:
            Console.WriteLine("Great! Your cart has been updated.");
            Console.WriteLine("1. Add more items to your cart.");
            Console.WriteLine("2. View your cart and cart options.");
            var secondLoopChoice = Console.ReadLine();

            if (secondLoopChoice == "1")
            {
                Member member = new Member();
                member.BringMenu();
                var productChoice = Console.ReadLine();
                goto Start;
            }
            else if (secondLoopChoice == "2")
            {
                Console.WriteLine("Your shopping cart items are listed below");
                cart.ShowCart();
                Console.WriteLine("1. Checkout");
                Console.WriteLine("2. Delete Items from shopping cart");

                var cartOption = Console.ReadLine();

                if (cartOption == "1")
                {
                    cart.Checkout(currentUser);
                }

                else if (cartOption == "2")
                {
                    cart.ShowCart();
                    Console.WriteLine("Enter the corresponding number of the item you want to delete.");
                    var deleteProductChoice = Console.ReadLine();
                    cart.DeleteProduct(deleteProductChoice);
                    goto Back;
                }
                Console.ReadLine();
            }
            else if (secondLoopChoice != "1" || secondLoopChoice != "2")
            {
                Console.WriteLine("Oops that didn't work, try again");
                goto Back;
            }

            Console.ReadLine();
        }
    }
}
