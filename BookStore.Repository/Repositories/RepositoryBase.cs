using BookStore.Domain.Collection;
using BookStore.Domain.Interfaces.Repositories;
using BookStore.Helper;
using BookStore.Repository.Context;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Repositories
{
    public class RepositoryBase<TCollection> : IRepositoryBase<TCollection> where TCollection : MongoDbBase
    {
        private readonly MongoDbContext<TCollection> _context = null;

        public RepositoryBase(IOptions<ConfigSettings> settings)
        {
            _context = new MongoDbContext<TCollection>(settings);
        }

        public async Task Add(TCollection obj)
        {
            await _context.Collection.InsertOneAsync(obj);
        }

        public async Task Add(IEnumerable<TCollection> obj)
        {
            await _context.Collection.InsertManyAsync(obj);
        }

        public async Task Delete(string id)
        {
            ObjectId internalId = GetInternalId(id);
            await _context.Collection.DeleteOneAsync(x => x.id.Equals(id), null);
        }

        public async Task Delete(TCollection obj)
        {
            await _context.Collection.DeleteOneAsync(x => x.id.Equals(obj.id), null);
        }

        public async Task Delete(IEnumerable<TCollection> obj)
        {
            foreach (var item in obj)
            {
                await _context.Collection.DeleteOneAsync(x => x.id.Equals(item.id), null);
            }
        }

        public async Task<TCollection> Get(string id)
        {
            ObjectId internalId = GetInternalId(id);
            FindOptions<TCollection> options = new FindOptions<TCollection> { Limit = 1 };
            IAsyncCursor<TCollection> task = await _context.Collection.FindAsync(x => x.id.Equals(id), options);
            List<TCollection> list = await task.ToListAsync();
            return list.FirstOrDefault();
        }

        public async Task<IQueryable<TCollection>> Get()
        {
            IAsyncCursor<TCollection> task = await _context.Collection.FindAsync(_ => true, null);
            List<TCollection> list = await task.ToListAsync();
            return list.AsQueryable();
        }

        public async Task Update(TCollection obj)
        {
            ObjectId internalId = GetInternalId(obj.controlId);
            await _context.Collection.UpdateOneAsync(x => x.id.Equals(internalId), Builders<TCollection>.Update.Set(x => x, obj));
        }

        public async Task Update(IEnumerable<TCollection> obj)
        {
            foreach (var item in obj)
            {
                await _context.Collection.UpdateOneAsync(x => x.id.Equals(item.id), Builders<TCollection>.Update.Set(x => x, item));
            }
        }

        private ObjectId GetInternalId(string id)
        {
            ObjectId internalId;
            if (!ObjectId.TryParse(id, out internalId))
                internalId = ObjectId.Empty;

            return internalId;
        }
    }
}
