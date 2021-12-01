using Distro.Seedworks.Infrastructure.DataAccess;

namespace Distro.Admin.Contracts.Entities
{
    public class Customer : IDatabaseEntity
    {
        public Guid Id { get; set; }
    }
}
