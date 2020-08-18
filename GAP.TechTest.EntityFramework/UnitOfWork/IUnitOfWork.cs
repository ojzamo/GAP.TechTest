using GAP.TechTest.Core.Entities;
using GAP.TechTest.Core.Entities.Common;
using GAP.TechTest.EntityFramework.Repository;
using System;
using System.Data;

namespace GAP.TechTest.EntityFramework.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : class, IObjectState;
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        bool Commit();
        void Rollback();
    }
}
