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

        [TestMethod]
        public void Add_Ax1_To_Basket_And_Verify_Basket_Contents()
        {
            //Arrange
            var basket = new Basket();
            var item = "A";

            //Act
            basket.AddItem(item);
            var qty = basket.GetQuantity(item);

            //Assert
            Assert.AreEqual(1, qty);
        }

        [TestMethod]
        public void Add_Ax2_To_Basket_And_Verify_Basket_Contents()
        {
            //Arrange
            var basket = new Basket();
            var item = "A";

            //Act
            basket.AddItem(item);
            basket.AddItem(item);
            var qty = basket.GetQuantity(item);

            //Assert
            Assert.AreEqual(2, qty);
        }
    }
}
