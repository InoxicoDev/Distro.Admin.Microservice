using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Admin.Contracts.Entities
{
    public class User : IDatabaseEntity
    {
        public Guid Id { get; set; }
    }
}
