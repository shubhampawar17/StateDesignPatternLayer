using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternLayer.Models
{
    public class PaymentPendingState : IVendingMachineState
    {
        public void HandleRequest()
        {
            Console.WriteLine("Payment Pending state : Dispensing product");
        }
    }
}
