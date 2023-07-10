using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReading.Event.Repository;
using Microsoft.EntityFrameworkCore.Storage;

namespace BookReading.Event.Transaction
{
    interface IUnitOfWork : IDisposable
    {
        int Save();
        void RollBack();
        IDbContextTransaction BeginTransaction();
        Task<int> SaveAsync();
    }
}
