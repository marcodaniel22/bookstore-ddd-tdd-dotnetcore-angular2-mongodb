using BookStore.Domain.Collection;
using BookStore.Domain.IRepository;
using BookStore.Domain.IRepository.Repositories;
using BookStore.Helper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(IOptions<ConfigSettings> settings)
            : base(settings)
        {
            
        }
    }
}
