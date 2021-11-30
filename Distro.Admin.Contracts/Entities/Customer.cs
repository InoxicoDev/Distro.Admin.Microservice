using Distro.Seedworks.DataAccess.Respository.Contracts;

namespace Distro.Admin.Contracts.Entities
{
    public class Customer : IDatabaseEntity
    {
        public Guid Id { get; set; }
    }
}
