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
            // Arrange

            ShoppingCart shoppingCart;
            shoppingCart = new ShoppingCart();
            var cart = shoppingCart.MemberShoppingCart;

            Product basketball = new Product(10, "Basketball");

            List<Product> shoppingCart2 = new List<Product>();
            shoppingCart2.Add(basketball);


            // Act  
            shoppingCart.AddProduct(basketball);
            var cart2 = shoppingCart2;

            //Assert
            Assert.AreEqual(cart, cart2);
        }
    }
}
