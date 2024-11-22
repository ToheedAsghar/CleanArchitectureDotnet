using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Application
{
    public class GetAllCustomersUseCase
    {
        private readonly ICustomerRepository _customerRepository;

        public GetAllCustomersUseCase(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerRepository.GetAll();
        }
    }
}
