using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Presentation.Common.Structures
{
    public struct SpecialtyRequest
    {
        public SpecialtyRequest(ObjectId id,string name, int course)
        {
            Id=id;
            Name=name;
            Course=course;
        }

        public ObjectId Id { get; }

        public string Name { get; }
        public int Course { get; }
    }
}
