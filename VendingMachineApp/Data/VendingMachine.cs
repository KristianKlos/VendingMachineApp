using System;
using System.Collections.Generic;
using VendingMachineApp.Model;
using System.Text;

namespace VendingMachineApp.Data
{
    public class VendingMachine : IVending

    {
        readonly int[] moneyDenom = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        int moneyPool;
        public int MoneyPool { get { return moneyPool; } }
        public Product[] Products = new Product[] { new Chips(), new PowerBar(), new Drink() };

        public void InsertMoney(int currency)
        {
            if (Array.Find(moneyDenom, money => money == currency) != 0)
            { moneyPool += Convert.ToInt32(currency); }
            else
            { throw new ArgumentException("Enough money inserted?"); }
        }

        public Product Purchase(int Id)
        {
            Product productSelect = Array.Find(Products, product => product.productId == Id);

            if (productSelect == null)
            { throw new ArgumentException("Product doesn't exist"); }

            if (productSelect.productPrice > moneyPool)
            { throw new ArgumentException("Not enough money"); }
            else
            { moneyPool = moneyPool - productSelect.productPrice; }
            return productSelect;
        }

        public void PrintAll()
        {
            foreach (Product product in Products)
            { Console.WriteLine(product.Examine()); }
        }

        public Dictionary<int, int> EndTransaction()
        {
            Dictionary<int, int> changeDictionary = new Dictionary<int, int>();
            for (int i = moneyDenom.Length - 1; i >= 0; i--)
            {
                int change = moneyPool / moneyDenom[i];
                if (change != 0)
                { changeDictionary.Add(moneyDenom[i], change); }
                moneyPool %= moneyDenom[i];
            }
            return changeDictionary;
        }






    }
}