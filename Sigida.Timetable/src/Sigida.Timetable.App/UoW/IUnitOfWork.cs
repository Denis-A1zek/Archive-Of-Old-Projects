using MongoDB.Bson;
using Sigida.Timetable.Data.Repository;


namespace Sigida.Timetable.Data.UoW;

public interface IUnitOfWork : IDisposable
{
    Task<bool> Commit();
    IRepository<TEntity, ObjectId> GetRepository<TEntity>();
}
