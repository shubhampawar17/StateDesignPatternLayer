using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternLayer.Models
{
    public interface IVendingMachineState
    {
        void HandleRequest();
    }
}
