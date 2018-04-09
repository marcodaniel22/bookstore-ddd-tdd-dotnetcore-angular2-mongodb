using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TCollection> where TCollection : class
    {
        Task<TCollection> Get(string id);
        Task<IQueryable<TCollection>> Get();
        Task Add(TCollection obj);
        Task Add(IEnumerable<TCollection> obj);
        Task Update(TCollection obj);
        Task Update(IEnumerable<TCollection> obj);
        Task Delete(string id);
        Task Delete(TCollection obj);
        Task Delete(IEnumerable<TCollection> obj);
    }
}
