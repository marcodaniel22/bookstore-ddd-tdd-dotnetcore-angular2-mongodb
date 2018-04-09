using BookStore.Helper;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Context
{
    public class MongoDbContext<TColletion>
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IOptions<ConfigSettings> settings)
        {
            var client = new MongoClient(settings.Value.MongoConect);
            if (client != null)
                _database = client.GetDatabase(settings.Value.DataBase);
        }

        public IMongoCollection<TColletion> Collection
        {
            get
            {
                return _database.GetCollection<TColletion>(typeof(TColletion).ToString());
            }
        }
    }
}
