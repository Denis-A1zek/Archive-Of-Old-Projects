using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_mongo.Service
{
    public class ApplicationMongoContext : MongoContext
    {
        private MongoContext _context;
        private IMongoDatabase _database;

        public ApplicationMongoContext(string connectionString) : base(connectionString)
        {
            _database = Client.GetDatabase("Objective");
        }

        public IMongoCollection<Product> Products => _database.GetCollection<Product>("Product");
        public IMongoCollection<Supply> Supplys => _database.GetCollection<Supply>("Delivery");

    }
}
