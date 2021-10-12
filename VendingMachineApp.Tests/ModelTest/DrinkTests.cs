using System;
using System.Text;
using System.Collections.Generic;
using VendingMachineApp.Data;
using VendingMachineApp.Model;
using Xunit;

namespace VendingMachineApp.Tests.ModelTest
{
    public class DrinkTests
    {
        [Fact]
        public void DrinkUseTestMessage()
        {
            //Arrange
            VendingMachine vending = new VendingMachine();
            VendingMachine.InsertMoney(100);
            Product product = VendingMachine.Purchase(2);

            string expectedDrinkMessage = "Enjoy the drink";

            //Act
            string result = product.Use();

            //Assert
            Assert.Equal(expectedDrinkMessage, result);
        }
        [Fact]
        public void DrinkExamineTestMessage()
        {
            //Arrange
            VendingMachine vending = new VendingMachine();
            VendingMachine.InsertMoney(100);
            Product product = VendingMachine.Purchase(2);

            string expectedDrinkMessage = $"{productId}\n{productName}\n{productPrice} kr";

            //Act
            string result = product.Examine();

            //Assert
            Assert.Equal(expectedDrinkMessage, result);

        }


    }
}
