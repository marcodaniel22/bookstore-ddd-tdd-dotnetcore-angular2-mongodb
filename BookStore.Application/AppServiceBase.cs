using BookStore.Application.Interfaces;
using BookStore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application
{
    public class AppServiceBase<TCollection> : IAppServiceBase<TCollection> where TCollection : class
    {
        private readonly IServiceBase<TCollection> _serviceBase;

        public AppServiceBase(IServiceBase<TCollection> serviceBase)
        {
            this._serviceBase = serviceBase;
        }

        public async Task Add(TCollection obj)
        {
            await _serviceBase.Add(obj);
        }

        public async Task Add(IEnumerable<TCollection> obj)
        {
            await _serviceBase.Add(obj);
        }

        public async Task Delete(int id)
        {
            await _serviceBase.Delete(await _serviceBase.Get(id));
        }

        public async Task Delete(TCollection obj)
        {
            await _serviceBase.Delete(obj);
        }

        public async Task Delete(IEnumerable<TCollection> obj)
        {
            await _serviceBase.Delete(obj);
        }

        public async Task<TCollection> Get(int id)
        {
            return await _serviceBase.Get(id);
        }

        public async Task<IQueryable<TCollection>> Get()
        {
            return await _serviceBase.Get();
        }

        public async Task Update(TCollection obj)
        {
            await _serviceBase.Update(obj);
        }

        public async Task Update(IEnumerable<TCollection> obj)
        {
            await _serviceBase.Update(obj);
        }
    }
}
