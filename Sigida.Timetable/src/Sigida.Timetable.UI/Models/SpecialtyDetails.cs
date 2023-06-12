using MongoDB.Bson;
using Sigida.Timetable.UI.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Models
{
    public class SpecialtyDetails : ISpecialtyInfo
    {
        public SpecialtyDetails(ObjectId id, string name, int course)
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
