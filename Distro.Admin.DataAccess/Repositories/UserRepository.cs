using Distro.Admin.Contracts.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Distro.Admin.DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
