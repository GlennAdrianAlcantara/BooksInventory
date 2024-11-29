using System;
using System.Collections.Generic;
using BooksInventory.DAO;
using BooksInventory.Models;

namespace BooksInventory.Services
{
    public class BooksServices
    {
        private readonly BooksRepository _booksRepository;

        public BooksServices(BooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public List<BookItem> GetAllBooks()
        {
            return _booksRepository.GetAllBooks();
        }

        public BookItem GetBookById(int id)
        {
            return _booksRepository.GetBookById(id);
        }

        public void AddBook(BookItem bookItem)
        {
            _booksRepository.AddBook(bookItem);
        }

        public void DeleteBook(int id)
        {
            _booksRepository.DeleteBook(id);
        }

        public void UpdateBook(BookItem bookItem)
        {
            _booksRepository.UpdateBook(bookItem);
        }
    }
}
