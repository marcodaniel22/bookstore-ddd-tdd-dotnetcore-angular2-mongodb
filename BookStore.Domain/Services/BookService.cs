using BookStore.Domain.Collection;
using BookStore.Domain.Interfaces.Services;
using BookStore.Domain.IRepository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Services
{
    public class BookService : ServiceBase<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
            : base(bookRepository)
        {
            this._bookRepository = bookRepository;
        }
    }
}
