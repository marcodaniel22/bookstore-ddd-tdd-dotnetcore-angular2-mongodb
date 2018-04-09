using BookStore.Domain.Collection;
using BookStore.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.IRepository.Repositories
{
    public interface IBookRepository : IRepositoryBase<Book>
    {

    }
}
