using System;
using System.Collections.Generic;
using VendingMachineApp.Data;
using System.Text;

namespace VendingMachineApp.Model
{
    class PowerBar : Product
    {
        public PowerBar()
        {
            productId = 1;
            productName = "Monkey Bar";
            productPrice = 15;
        }

        public override string Examine()
        {
            return $"{productId}\n{productName}\n{productPrice} kr";
        }

        public override string Use()
        {
            return "Sample Text(Äta)";
        }
    }
}
