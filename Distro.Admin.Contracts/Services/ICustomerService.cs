using Distro.Admin.Contracts.Entities;

namespace Distro.Admin.Contracts.Services
{
    public interface ICustomerService
    {
        public Customer GetCustomerById(Guid id);

        public Customer AddCustomer(Customer customer);
    }
}
