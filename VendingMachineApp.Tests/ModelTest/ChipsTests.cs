using System;
using System.Text;
using System.Collections.Generic;
using VendingMachineApp.Data;
using VendingMachineApp.Model;
using Xunit;

namespace VendingMachineApp.Tests.ModelTest
{
    public class ChipsTests
    {
        [Fact]
        public void ChipsUseTest()
        {
            //Arrange
            VendingMachine vending = new VendingMachine();
            VendingMachine.InsertMoney(100);
            Product product = VendingMachine.Purchase(0);

            string expectedChipsMessage = "Enjoy the chips";

            //Act
            string result = product.Use();

            //Assert
            Assert.Equal(expectedChipsMessage, result);
        }
        [Fact]
        public void ChipsExamineTest()
        {
            //Arrange
            VendingMachine vending = new VendingMachine();
            VendingMachine.InsertMoney(100);
            Product product = VendingMachine.Purchase(0);

            string expectedChipsMessage = $"{productId}\n{productName}\n{productPrice} kr";

            //Act
            string result = product.Examine();

            //Assert
            Assert.Equal(expectedChipsMessage, result);
        }
    }
}
