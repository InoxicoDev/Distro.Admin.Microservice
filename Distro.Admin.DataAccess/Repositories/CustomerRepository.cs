﻿using Distro.Admin.Contracts.Entities;
using Distro.Seedworks.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Distro.Admin.DataAccess.Repositories
{
    internal class CustomerRepository : RepositoryBase<Customer>
    {
        public CustomerRepository(DbContext dataContext) : base(dataContext)
        {
        }
    }
}
