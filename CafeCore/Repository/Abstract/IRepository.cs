using CafeCore.Model.Abstracts;
using System;
using System.Linq;

namespace CafeCore.Repository.Abstract
{
    public interface IRepository<T, TId> where T: BaseEntity
    {
        T GetById(TId id);
        IQueryable<T> Get(Func<T, bool> predicate = null);
        void Add(T entity, bool isSaveLater = false);
        void Remove(T entity, bool isSaveLater = false);
        void Update(T entity, bool isSaveLater = false);

        int Save();

    }
}
