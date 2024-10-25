using StateDesignPatternLayer.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternLayer.Presentation
{
    public static class VendingMachinePresentation
    {
        public static void StartVendingMachine()
        {
            VendingMachineController controller = new VendingMachineController();
            Console.WriteLine("Initializing the vending machine.."); // Initialize the vending machine
            controller.InitializeMachine();
            Console.WriteLine("Selecting the product"); // select the product to state the change
            controller.SelectProduct();
            Console.WriteLine("Processing the payment"); // here we proceed to payment state
            controller.ProcessPayment();
            Console.WriteLine("product not available so out of stock state"); // product not available in vending machine
            controller.SetOutOfStock(); 
        }
    }
}
