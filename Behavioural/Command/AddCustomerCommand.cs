using Behavioural.Command.FX;

namespace Behavioural.Command
{
    public class AddCustomerCommand: ICommand
    {
        private readonly CustomerService _service;

        public AddCustomerCommand(CustomerService service)
        {
            _service = service;
        }
        public void Execute()
        {
            _service.AddCustomer();
        }
    }
}