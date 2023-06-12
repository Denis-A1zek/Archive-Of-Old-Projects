
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Data.Repository
{
    public interface IRepository<TEntity, KId>
    {
        IReadOnlyCollection<TEntity> FindAll();
        IReadOnlyCollection<TEntity> Find(Expression<Func<TEntity, bool>> predicat);
        TEntity FindById(KId id);
        void Insert(TEntity entity);
        void Delete(KId id);
        void Update(TEntity entity);

        bool Exsist(TEntity entity);
    }
}
