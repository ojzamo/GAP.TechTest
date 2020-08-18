using System.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GAP.TechTest.Core.Entities;
using GAP.TechTest.Core.Entities.Common;

namespace GAP.TechTest.EntityFramework.DataContext
{
    public interface IDataContextAsync : IDisposable
    {
        int SaveChanges();
        void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState;
        void SyncObjectsStatePostCommit();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
    }
}
