using System;

namespace ShoppingCart2
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    var currentUser = carr;
                    Console.WriteLine("Welcome Carr. Thank you for being a gold member with us. Below is a list of our products.");
                    carr.BringMenu();
                    break;
                }
                else if (MemId == "Kevin OConnor")
                {
                    SilverMember kevin = new SilverMember(02, "Kevin OConnor");
                    var currentUser = kevin;
                    Console.WriteLine("Welcome Kevin. Thank you for being a silver member with us. Below is a list of our products.");
                    kevin.BringMenu();
                    break;
                }
                else if (MemId == "Caroline OConnor")
                {
                    SilverMember caroline = new SilverMember(03, "Caroline OConnor");
                    var currentUser = caroline;
                    Console.WriteLine("Welcome Caroline. Thank you for being a silver member with us. Below is a list of our products.");
                    caroline.BringMenu();
                    break;
                }
                else if (MemId == "Cali OConnor")
                {
                    BronzeMember cali = new BronzeMember(04, "Cali OConnor");
                    var currentUser = cali;
                    Console.WriteLine("Welcome Caroline. Thank you for being a silver member with us. Below is a list of our products.");
                    cali.BringMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("That does look like a registered member. Lets try that again");
                }

            } while (true);

            var productChoice = Console.ReadLine();
            do
            {
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
                else
                {
                    Console.WriteLine("That does not look like a valid product. Try again");
                }
            } while (true);

            Console.ReadLine();
            Console.WriteLine("Great! Item has been added to your cart.");
            Console.WriteLine("1. Add more items to your cart.");
            Console.WriteLine("2. View your cart and cart options.");
            var secondLoopChoice = Console.ReadLine();

            if (secondLoopChoice == "1")
            {
                Member member = new Member();
                member.BringMenu();
                var otherProductChoice = Console.ReadLine();
                do
                {
                    if (otherProductChoice == "1")
                    {
                        cart.AddProduct(basketball);
                        break;
                    }
                    else if (otherProductChoice == "2")
                    {
                        cart.AddProduct(sunglasses);
                        break;
                    }
                    else if (otherProductChoice == "3")
                    {
                        cart.AddProduct(shoes);
                        break;
                    }
                    else if (otherProductChoice == "4")
                    {
                        cart.AddProduct(umbrella);
                        break;
                    }
                    else if (otherProductChoice == "5")
                    {
                        cart.AddProduct(flipflops);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That does not look like a valid product. Try again");
                    }
                } while (true);
            }
            else if (secondLoopChoice == "2")
            {
                Console.WriteLine("Your shopping cart items are listed below");
                cart.ShowCart();
                Console.WriteLine("1. Checkout");
                Console.WriteLine("1. Delete Items from shopping cart");

                var cartOption = Console.ReadLine();

                if (cartOption == "1")
                {
                    cart.Checkout();
                }

                else if (cartOption == "2")
                {
                    cart.ShowCart();
                    Console.WriteLine("Enter the corresponding number of the item you want to delete.");
                    var deletedItem = Console.ReadLine();

                    if (deletedItem == "1")
                    {
                        Console.WriteLine("Item deleted");
                    }
                }

            }

            Console.ReadLine();

        }
    }
}
