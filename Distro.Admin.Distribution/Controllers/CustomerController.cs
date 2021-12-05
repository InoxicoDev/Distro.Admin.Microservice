using Distro.Admin.Contracts.Entities;
using Distro.Admin.Contracts.Services;
using Distro.Admin.DataAccess;
using Distro.Ordering.Distribution.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Distro.Admin.Distribution.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : CustomControllerBase, ICustomerService
    {
        ICustomerService? _orderService;

        public CustomerController(ApplicationDbContext dbContext, ICustomerService? service = null) : base(dbContext)
        {
            _orderService = service;
        }

        [HttpGet("GetCustomerById/{id}")]
        public Customer GetCustomerById(Guid id)
        {
            Customer? customer = null;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                customer = _orderService?.GetCustomerById(id);

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return customer;
        }

        [HttpPost("AddOrder")]
        public Customer AddCustomer(Customer customer)
        {
            Customer? addedCustomer = null;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                addedCustomer = _orderService.AddCustomer(customer);
                context.SaveChanges();

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return addedCustomer;
        }
    }
}
