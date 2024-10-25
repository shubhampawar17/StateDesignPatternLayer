using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternLayer.Models
{
    public class OutOfState : IVendingMachineState
    {
        public void HandleRequest()
        {
            Console.WriteLine("Out of stock state : Product unavailable . Please select another product");
        }
    }
}
