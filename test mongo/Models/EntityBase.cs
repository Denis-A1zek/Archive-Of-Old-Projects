﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_mongo.Models
{
    public class EntityBase
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}
