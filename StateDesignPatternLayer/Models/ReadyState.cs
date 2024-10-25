using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternLayer.Models
{
    public class ReadyState : IVendingMachineState
    {
        public void HandleRequest()
        {
            Console.WriteLine("Ready state: Please select a product");
        }
    }
}
