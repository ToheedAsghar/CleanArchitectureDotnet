using Core.Entities;

namespace Core.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        void AddCustomer(Customer customer);
    }
}
