using Microsoft.AspNetCore.Mvc;
using Core.Entities;
using Application;

namespace Web.Controllers
{
    public class CustomerController : Controller
    {
        private GetAllCustomersUseCase _getAllCustomers;
        private AddCustomerUseCase _addCustomerUseCase;
        public CustomerController(GetAllCustomersUseCase getAllCustomers, AddCustomerUseCase addCustomer)
        {
            _getAllCustomers = getAllCustomers;
            _addCustomerUseCase = addCustomer;
        }
        public IActionResult Index()
        {
            var customers = _getAllCustomers.GetAllCustomers();
            return View(customers);
        }

        public IActionResult AllCustomers()
        {
            var customers = _getAllCustomers.GetAllCustomers();
            return View(customers);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            if(ModelState.IsValid)
            {
                _addCustomerUseCase.AddCustomer(customer);
                var customers = _getAllCustomers.GetAllCustomers();
                return RedirectToAction("AllCustomers");
            }
            return View();
        }
    }
}
