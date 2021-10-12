using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineApp.Model
{

    public interface IVending
    {
        public void PrintAll();
        public void InsertMoney(int currency);
        public Product Purchase(int id);
        Dictionary<int, int> EndTransaction();
    }
}
