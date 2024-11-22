using Core.Entities;
using Core.Interfaces;

namespace Application
{
    public class AddCustomerUseCase
    {
        private readonly ICustomerRepository _customerRepository;
        public AddCustomerUseCase(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }
    }
}
