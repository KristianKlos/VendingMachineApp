using System;
using System.Collections.Generic;
using VendingMachineApp.Data;
using System.Text;

namespace VendingMachineApp.Model
{
    class Chips : Product
    {
        public Chips()
        {
            productId = 0;
            productName = "Lättsaltat";
            productPrice = 5;
        }

        public override string Examine()
        {
            return $"{productId}\n{productName}\n{productPrice} kr";
        }

        public override string Use()
        {
            return "Enjoy the chips";
        }
    }
}
