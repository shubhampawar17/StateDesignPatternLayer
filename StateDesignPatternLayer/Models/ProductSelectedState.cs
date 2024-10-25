using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternLayer.Models
{
    public class ProductSelectedState : IVendingMachineState
    {
        public void HandleRequest()
        {
            Console.WriteLine("Product selected state : Processing Payment");
        }
    }
}
