using Core.Entities;
using Core.Interfaces;

namespace Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        public static List<Customer> _customers = new List<Customer> 
        {
            new Customer{Id=1, Name="Toheed", Description = "Student"},
            new Customer{Id=2, Name="Ali", Description="Warrior"},
        };
        public IEnumerable<Customer> GetAll()
        {
            return _customers;
        }
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}
