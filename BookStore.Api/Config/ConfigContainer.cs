using BookStore.Application;
using BookStore.Application.Interfaces;
using BookStore.Domain.Interfaces.Services;
using BookStore.Domain.IRepository.Repositories;
using BookStore.Domain.Services;
using BookStore.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Api.Config
{
    public static class ConfigContainer
    {
        public static void Config(IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookAppService, BookAppService>();
            services.AddScoped<IBookService, BookService>();
        }
    }
}
