using BookStore.Domain.Interfaces.Repositories;
using BookStore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Services
{
    public class ServiceBase<TCollection> : IServiceBase<TCollection> where TCollection : class
    {
        private readonly IRepositoryBase<TCollection> _repository;

        public ServiceBase(IRepositoryBase<TCollection> repository)
        {
            this._repository = repository;
        }

        public async Task Add(TCollection obj)
        {
            await _repository.Add(obj);
        }

        public async Task Add(IEnumerable<TCollection> obj)
        {
            await _repository.Add(obj);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(await _repository.Get(id.ToString()));
        }

        public async Task Delete(TCollection obj)
        {
            await _repository.Delete(obj);
        }

        public async Task Delete(IEnumerable<TCollection> obj)
        {
            await _repository.Delete(obj);
        }

        public async Task<TCollection> Get(int id)
        {
            return await _repository.Get(id.ToString());
        }

        public async Task<IQueryable<TCollection>> Get()
        {
            return await _repository.Get();
        }

        public async Task Update(TCollection obj)
        {
            await _repository.Update(obj);
        }

        public async Task Update(IEnumerable<TCollection> obj)
        {
            await _repository.Update(obj);
        }
    }
}
