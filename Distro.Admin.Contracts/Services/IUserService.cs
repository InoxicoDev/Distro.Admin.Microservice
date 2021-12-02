using Distro.Admin.Contracts.Entities;

namespace Distro.Admin.Contracts.Services
{
    public interface IUserService
    {
        public User GetUserById(Guid id);

        public User AddUser(User user);

        public User UpdateUser(User user);
    }
}
