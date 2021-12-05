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
    public class UserController : CustomControllerBase, IUserService
    {
        IUserService? _userService;

        public UserController(ApplicationDbContext dbContext, IUserService? service = null) : base(dbContext)
        {
            _userService = service;
        }

        [HttpGet("GetUserById/{id}")]
        public User GetUserById(Guid id)
        {
            User? user = null;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                user = _userService?.GetUserById(id);

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return user;
        }

        [HttpPost("AddUser")]
        public User AddUser(User user)
        {
            User? addedUser = null;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                addedUser = _userService.AddUser(user);
                context.SaveChanges();

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return addedUser;
        }

        [HttpPut("UpdateUser")]
        public User UpdateUser(User user)
        {
            User? updatedUser = null;

            try
            {
                using TransactionScope ts = new TransactionScope(TransactionScopeOption.Required, TransactionScopeAsyncFlowOption.Enabled);
                logger.Info($"Test logging Controller");

                updatedUser = _userService.UpdateUser(user);
                context.SaveChanges();

                ts.Complete();
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }

            return updatedUser;
        }
    }
}
