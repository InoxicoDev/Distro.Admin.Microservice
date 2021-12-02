using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Admin.Contracts.Entities
{
    public class User : IDatabaseEntity
    {
        public Guid Id { get; set; }
        
        public string UserId { get; set; }

        public string Name { get; set; }

    }
}
