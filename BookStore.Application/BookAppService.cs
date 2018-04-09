using BookStore.Application.Interfaces;
using BookStore.Domain.Collection;
using BookStore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Application
{
    public class BookAppService : AppServiceBase<Book>, IBookAppService
    {
        private readonly IBookService _bookService;

        public BookAppService(IBookService bookService)
            :base(bookService)
        {
            this._bookService = bookService;
        }
    }
}
