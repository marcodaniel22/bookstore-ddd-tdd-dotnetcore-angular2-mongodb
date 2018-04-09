using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Collection
{
    public class MongoDbBase
    {
        [BsonId]
        public ObjectId id { get; set; }

        public string controlId { get; set; }
    }
}
