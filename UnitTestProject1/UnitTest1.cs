using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            ShoppingCart shoppingCart = new ShoppingCart();
            ShoppingCart shoppingCart2 = new ShoppingCart();

            Product basketball = new Product(10, "Basketball");

            shoppingCart.AddProduct(basketball);
            //Act 

            shoppingCart2.AddProduct(basketball);


            //Assert
            Assert.AreEqual(shoppingCart, shoppingCart2);
        }

        [TestMethod]
        public void TestDelete()
        {
            //Arrange

            ShoppingCart cart = new ShoppingCart();
            List<Product> MemberShoppingCart = new List<Product>();
            List<Product> MemberShoppingCart2 = new List<Product>();

            Product basketball = new Product(10, "Basketball");
            MemberShoppingCart.Add(basketball);

            var deleteProductChoice = "0";

            //Act

            cart.DeleteProduct(deleteProductChoice);

            //Assert

            Assert.AreEqual(MemberShoppingCart2, MemberShoppingCart);
        }

        [TestMethod]
        public void TestSubtotal()
        {
            //Wait to see how Auri works one of the above to finish this 
            //
            //
        }
    }
}
