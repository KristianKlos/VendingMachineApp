using System;
using VendingMachineApp.Data;

namespace VendingMachineApp
{
    class Program
    {
        public VendingMachine vendingMachine = new VendingMachine();
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();

            Console.WriteLine("Vending Machine");

            bool menuLoop = true;

            while (menuLoop)
            {
                Console.WriteLine("Menu\n1: Insert Money\n2: Show Products\n3: Buy Product\n4: End Transaction\n9: Quit");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        //Insert Money
                        break;
                    case '2':
                        //Show Products
                        break;
                    case '3':
                        //Buy Product
                        break;
                    case '4':
                        //End Transaction
                        break;
                    case '9':
                        menuLoop = false;
                        break;

                    default:
                        break;
                }
                if (menuLoop)
                {
                    Console.WriteLine("Press ANY key to continue");
                }
            }
            Console.WriteLine("Press ANY key to exit");
        }

    }
}


