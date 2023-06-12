using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Common.Interfaces;

public interface ISpecialtyInfo
{
    public ObjectId Id { get; }
    public string Name { get; }
    public int Course { get; }
}
