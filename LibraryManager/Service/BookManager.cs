using System.Collections.Immutable;
using LibraryManager.Interfaces;
using LibraryManager.Model;

namespace LibraryManager.Service {
    public class BookManager : IBookManager {
        private List<Book?> _books = new();
        private int _nextId = 1;

        public void AddBook(Book book) {
            if(book == null) throw new ArgumentNullException(nameof(book));

            book.Id = _nextId++;
            _books.Add(book);
        }

        public void RemoveBook(int bookId) {
            Book? book = _books.FirstOrDefault(b => b.Id == bookId);
            if(book != null) _books.Remove(book);
        }

        public Book FindBookById(int bookId) {
            return _books.FirstOrDefault(b => b.Id == bookId);
        }

        public List<Book> GetAllBooks() {
            return _books;
        }
    }
}
