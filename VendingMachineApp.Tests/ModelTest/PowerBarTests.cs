using System;
using System.Text;
using System.Collections.Generic;
using VendingMachineApp.Data;
using VendingMachineApp.Model;
using Xunit;

namespace VendingMachineApp.Tests.ModelTest
{
    public class PowerBarTests
    {
        [Fact]
        public void ProductPowerBarUseStringMessageTest()
        {
            //Arrange
            VendingMachine vending = new VendingMachine();
            vendingMachine.InsertMoney(100);
            Product product = vendingMachine.Purchase(1);

            string expectedPowerBarMessage = "Enjoy the Power Bar";

            //Act
            string result = product.Use();

            //Assert
            Assert.Equal(expectedPowerBarMessage, result);

        }
        [Fact]
        public void PowerBarExamineTest()
        {
            //Arrange
            VendingMachine vending = new VendingMachine();
            VendingMachine.InsertMoney(100);
            Product product = VendingMachine.Purchase(1);

            string expectedPowerBarMessage = $"{productId}\n{productName}\n{productPrice} kr";

            //Act
            string result = product.Examine();

            //Assert
            Assert.Equal(expectedPowerBarMessage, result);
        }
    }
}
