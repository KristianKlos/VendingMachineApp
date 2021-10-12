using System;
using System.Text;
using System.Collections.Generic;
using VendingMachineApp.Data;
using VendingMachineApp.Model;
using Xunit;

namespace VendingMachine.Tests.DataTest
{
    public class VendingMachineTests
    {
        [Fact]
        public void CorrectAmountOfChange()
        {
            //Arange
            int expectedCurrency = 8;
            int[] exepectedMoney = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

            //Act
            int[] result = exepectedMoney;

            //Assert
            Assert.Equal(expectedCurrency, result.Length);
            Assert.Equal(exepectedMoney, result);
            Assert.NotNull(result);

        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(50)]
        [InlineData(100)]
        [InlineData(500)]
        [InlineData(1000)]
        public void InsertMoney(int currency)
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();

            //Act
            vendingMachine.InsertMoney(currecy);

            //Act
            Assert.Equal(currecy, vendingMachine.MoneyPool);

        }
        public void BuyCokeInsufficantMoney()
        {
            //Arrange;
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.InsertMoney(5); //Coke costs 10 kr
            
            //Act
            ArgumentException result = Assert.Throws<ArgumentException>(() => vendingMachine.Purchase(1));

            //Assert
            Assert.Equal("Not enough money", result.Message);
        }
}
