﻿using BookStore.Core.Models;

namespace BookStore.DataAccess.Repositories
{
    public interface IBookRepository
    {
        Task<Guid> Create(Book book);
        Task<Guid> Delete(Guid id);
        Task<List<Book>> GetBooks();
        Task<Guid> Update(Guid id, string title, string description, decimal price);
    }
}