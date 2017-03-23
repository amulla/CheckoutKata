using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutKata;

namespace CheckoutKata.Test
{
    [TestClass]
    public class CheckoutKataUnitTests

    {
        [TestMethod]
        public void Basket_Contains_Ax1_TotalPrice_Is_50()
        {
            //Arrange
            var checkout = new Checkout();
            var item = "A";

            //Act
            checkout.Scan(item);
            var totalPrice = checkout.GetTotalPrice();

            //Assert
            Assert.AreEqual(50, totalPrice);
        }

        [TestMethod]
        public void Basket_Contains_Ax2_TotalPrice_Is_100()
        {
            //Arrange
            var checkout = new Checkout();
            var item = "A";

            //Act
            checkout.Scan(item);
            checkout.Scan(item);
            var totalPrice = checkout.GetTotalPrice();

            //Assert
            Assert.AreEqual(100, totalPrice);
        }

        [TestMethod]
        public void CreateBasket()
        {
            //Arrange
            var basket = new Basket();

            //Act

            //Assert
            Assert.IsInstanceOfType(basket, typeof(IBasket));
        }
    }
}
