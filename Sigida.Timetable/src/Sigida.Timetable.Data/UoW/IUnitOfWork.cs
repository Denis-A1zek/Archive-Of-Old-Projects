using MongoDB.Bson;
using Sigida.Timetable.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Data.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
        IRepository<TEntity, ObjectId> GetRepository<TEntity>();
    }
}
