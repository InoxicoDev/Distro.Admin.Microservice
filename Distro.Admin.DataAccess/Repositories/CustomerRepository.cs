using Distro.Admin.Contracts.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Distro.Admin.DataAccess.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        public CustomerRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
