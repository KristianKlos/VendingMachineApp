using System;
using System.Collections.Generic;
using VendingMachineApp.Data;
using System.Text;

namespace VendingMachineApp.Model
{
    public abstract class Product
    {

        public int productId { get; set; }
        public int productPrice { get; set; }
        public string productName { get; set; }
        public abstract string Examine();
        public abstract string Use();
    }

}
