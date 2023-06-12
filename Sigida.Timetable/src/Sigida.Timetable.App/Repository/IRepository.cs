
using System.Linq.Expressions;

namespace Sigida.Timetable.Data.Repository;

public interface IRepository<TEntity, KId>
{
    Task<IEnumerable<TEntity>> FindAll();
    Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicat);
    Task<TEntity> FindById(KId id);
    void Insert(TEntity entity);
    void Delete(KId id);
    void Update(TEntity entity);
    Task<bool> Exsist(TEntity entity);
}
