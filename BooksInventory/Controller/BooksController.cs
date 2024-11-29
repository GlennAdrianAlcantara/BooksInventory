using System;
using System.Collections.Generic;
using BooksInventory.Models;
using BooksInventory.Services;

namespace BooksInventory.Controller
{
    public class BooksController
    {
        private readonly BooksServices _booksServices;

        public BooksController(BooksServices booksServices)
        {
            _booksServices = booksServices;
        }

        public List<BookItem> GetAllBooks()
        {
            return _booksServices.GetAllBooks();
        }

        public BookItem GetBookById(int id)
        {
            return _booksServices.GetBookById(id);
        }

        public void AddBook(string title, string author, string description, DateTime publishedDate, DateTime createdDate)
        {
            var newBook = new BookItem
            {
                Title = title,
                Author = author,
                Description = description,
                PublishedDate = publishedDate,
                CreatedDate = createdDate,  // Set created date
                UpdatedDate = DateTime.Now  // Set updated date as current date
            };

            _booksServices.AddBook(newBook);  // Add the new book using services
        }

        public void UpdateBook(BookItem updatedBook)
        {
            var bookItem = _booksServices.GetBookById(updatedBook.Id);
            if (bookItem != null)
            {
                bookItem.Title = updatedBook.Title;
                bookItem.Author = updatedBook.Author;
                bookItem.Description = updatedBook.Description;
                bookItem.PublishedDate = updatedBook.PublishedDate;
                bookItem.UpdatedDate = DateTime.Now; // Automatically set current date
                _booksServices.UpdateBook(bookItem);
            }
        }

        public void DeleteBook(int id)
        {
            _booksServices.DeleteBook(id);
        }
    }
}
