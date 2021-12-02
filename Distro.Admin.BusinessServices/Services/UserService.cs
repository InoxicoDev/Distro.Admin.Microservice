using Distro.Admin.Contracts.Entities;
using Distro.Admin.Contracts.Services;
using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Admin.BusinessServices.Services
{
    internal class UserService : IUserService
    {
        private IRepository<User> _userRepository;

        public UserService(IRepository<User> repository)
        {
            _userRepository = repository;
        }

        public User AddUser(User user)
        {
            return _userRepository.Add(user);
        }

        public User GetUserById(Guid id)
        {
            return _userRepository.GetById(id);
        }

        public User UpdateUser(User user)
        {
            var existingUser = _userRepository.GetById(user.Id);

            existingUser.Name = user.Name;
            existingUser.UserId = user.UserId;

            return existingUser;
        }
    }
}
