using LibraryManager.Model;
using LibraryManager.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Service {
    internal class SearchManager : Book {
        private BookManager bookManager;

        public SearchManager(BookManager manager) {
            this.bookManager = manager;
        }

        public void IdSearch() {
            Console.Write("검색할 책의 ID를 입력하세요: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Book book = bookManager.FindBookById(id);

            if(book != null) {
                Console.WriteLine($"ID: {book.Id}, 제목: {book.Title}, 저자: {book.Author}");
            } else {
                Console.WriteLine("해당 ID의 책을 찾을 수 없습니다.");
            }
        }

        public void TitleSearch() {
            Console.Write("검색할 책의 제목을 입력하세요: ");
            string title = Console.ReadLine();

            Book book = bookManager.FindBookByTitle(title);

            if(book != null) {
                Console.WriteLine($"ID: {book.Id}, 제목: {book.Title}, 저자: {book.Author}");
            } else {
                Console.WriteLine("해당 제목의 책을 찾을 수 없습니다.");
            }
        }

        public void AuthorSearch() {
            Console.Write("검색할 책의 저자를 입력하세요: ");
            string author = Console.ReadLine();

            Book book = bookManager.FindBookByAuthor(author);

            if(book != null) {
                Console.WriteLine($"ID: {book.Id}, 제목: {book.Title}, 저자: {book.Author}");
            } else {
                Console.WriteLine("해당 저자의 책을 찾을 수 없습니다.");
            }
        }
    }
}
