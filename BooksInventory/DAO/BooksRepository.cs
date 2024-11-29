using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BooksInventory.Data;
using BooksInventory.Models;

namespace BooksInventory.DAO
{
    public class BooksRepository
    {
        private readonly ApplicationDbContext _context;

        public BooksRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<BookItem> GetAllBooks()
        {
            return _context.BookItems.ToList();
        }

        public BookItem GetBookById(int id)
        {
            return _context.BookItems.Find(id);
        }

        public void AddBook(BookItem bookItem)
        {
            _context.BookItems.Add(bookItem);
            _context.SaveChanges();
        }

        public void UpdateBook(BookItem bookItem)
        {
            _context.BookItems.Update(bookItem);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            var book = _context.BookItems.Find(id);
            if (book != null)
            {
                _context.BookItems.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
