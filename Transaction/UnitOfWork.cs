using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using BookReading.Event.Repository;
using Microsoft.EntityFrameworkCore;
using Lw.Diagnostics;

namespace BookReading.Event.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext DbContext;
        private readonly IExceptionManager _exceptionManager;


        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork{TContext}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        protected UnitOfWork(DbContext context, IExceptionManager exceptionManager)
        {
            DbContext = context;
            _exceptionManager = exceptionManager;
        }

        internal virtual DbContext Context
        {
            get
            {
                return DbContext;
            }
        }




        private bool _disposedValue;



        /// <summary>
        /// Dispose the object
        /// </summary>
        /// <param name="disposing">IsDisposing</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    if (DbContext != null)
                    {
                        DbContext.Dispose();
                    }
                }
            }
            _disposedValue = true;
        }




        public void Dispose()
        {
            Dispose(true);



            GC.SuppressFinalize(this);
        }



        public int Save()
        {
            return Context.SaveChanges();
        }



        public Task<int> SaveAsync()
        {
            return Context.SaveChangesAsync();
        }




        public void RollBack()
        {
            DbContext.Database.RollbackTransaction();
        }



        public IDbContextTransaction BeginTransaction()
        {
            return DbContext.Database.BeginTransaction();
        }
    }
}
