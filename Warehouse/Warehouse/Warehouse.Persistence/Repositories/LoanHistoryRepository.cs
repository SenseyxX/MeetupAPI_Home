﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Warehouse.Persistence.Context;
using Warehouse.Persistence.Entities;

namespace Warehouse.Persistence.Repositories
{
    class LoanHistoryRepository : Repository<LoanHistory> ,ILoanHistoryRepository
    {
        public LoanHistoryRepository(WarehouseContext warehouseContext)
         :base(warehouseContext)
        {           
        }       
    }
}
