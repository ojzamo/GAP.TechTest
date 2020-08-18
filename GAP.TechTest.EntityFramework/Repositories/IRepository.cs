using GAP.TechTest.Core.Entities;
using GAP.TechTest.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAP.TechTest.EntityFramework.Repository
{
   
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Find(params object[] keyValues);
        IQueryable<TEntity> SelectQuery(string query, params object[] parameters);
        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void InsertOrUpdateGraph(TEntity entity);
        void InsertGraphRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);        
        IQueryable<TEntity> Queryable();
        IRepository<T> GetRepository<T>() where T : class, IObjectState;
        void Refresh(TEntity entity);
        void Refresh(IEnumerable<TEntity> entities);
    }
    
}
