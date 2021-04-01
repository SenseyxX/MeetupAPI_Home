﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.Repositories
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetRangeAsync(CancellationToken cancellationToken);
    }
}