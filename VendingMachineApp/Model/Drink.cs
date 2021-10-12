using System;
using System.Collections.Generic;
using VendingMachineApp.Data;
using System.Text;

namespace VendingMachineApp.Model
{
    public class Drink : Product
    {
        public Drink()
        {
            productId = 2;
            productName = "Coca Cola";
            productPrice = 10;
        }

        public override string Examine()
        {
            return $"{productId}\n{productName}\n{productPrice} kr";
        }

        public override string Use()
        {
            return "Enjoy the drink";
        }

    }
}