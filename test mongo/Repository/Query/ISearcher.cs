using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_mongo.Repository.Query
{
    public interface ISearcher<T>
    {
        Func<T, bool> Find();
    }
}
