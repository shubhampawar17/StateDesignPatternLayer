using StateDesignPatternLayer.Models;
using StateDesignPatternLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternLayer.Controller
{
    public class VendingMachineController
    {
        private readonly VendingMachineService _vendingMachineService;
        public VendingMachineController()
        {
            _vendingMachineService = new VendingMachineService();   
        }
        public void InitializeMachine()
        {
            _vendingMachineService.SetState(new ReadyState());
            _vendingMachineService.Request();
        }
        public void SelectProduct()
        {
            _vendingMachineService.SetState(new ProductSelectedState());
            _vendingMachineService.Request();
        }
        public void ProcessPayment()
        {
            _vendingMachineService.SetState(new PaymentPendingState());
            _vendingMachineService.Request();
        }
        public void SetOutOfStock()
        {
            _vendingMachineService.SetState(new OutOfState());
            _vendingMachineService.Request();
        }
    }
}
