using StateDesignPatternLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternLayer.Service
{
    public class VendingMachineService
    {
        private IVendingMachineState _state;
        public void SetState(IVendingMachineState state)
        {
            this._state = state;
        }
        public void Request()
        {
            _state?.HandleRequest();
        }
    }
}
