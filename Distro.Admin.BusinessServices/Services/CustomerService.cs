using Distro.Admin.Contracts.Entities;
using Distro.Admin.Contracts.Services;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Admin.BusinessServices.Services
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> _customerRepository;

        public CustomerService(IRepository<Customer> repository)
        {
            _customerRepository = repository;
        }

        public Customer AddCustomer(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public Customer GetCustomerById(Guid id)
        {
            return _customerRepository.GetById(id);
        }
    }
}
