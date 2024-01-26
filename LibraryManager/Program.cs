using LibraryManager.Model;
using LibraryManager.Service;

BookManager bookManager = new();
SearchManager searchManager = new(bookManager);

while(true) {
    Console.WriteLine("1. 책 추가");
    Console.WriteLine("2. 책 삭제");
    Console.WriteLine("3. 책 검색");
    Console.WriteLine("4. 모든 책 보기");
    Console.WriteLine("5. 종료");

    Console.Write("옵션을 선택하세요: ");

    int option = Convert.ToInt32(Console.ReadLine());

    switch(option) {
        case 1:
            AddBook();
            break;
        case 2:
            RemoveBook();
            break;
        case 3:
            FindBook();
            break;
        case 4:
            DisplayAllBooks();
            break;
        case 5:
            return;
        default:
            Console.WriteLine("잘못된 선택입니다.");
            break;
    }
}

void AddBook() {
    Console.Write("책 제목: ");
    string title = Console.ReadLine();

    Console.Write("저자: ");
    string author = Console.ReadLine();

    Book book = new Book { Title = title, Author = author };
    bookManager.AddBook(book);

    Console.WriteLine("책이 추가되었습니다.");
}

void RemoveBook() {
    Console.Write("삭제할 책의 ID를 입력하세요: ");
    int id = Convert.ToInt32(Console.ReadLine());

    bookManager.RemoveBook(id);

    Console.WriteLine("책이 삭제되었습니다.");
}

void FindBook() {
    Console.WriteLine("1. ID로 검색");
    Console.WriteLine("2. 제목으로 검색");
    Console.WriteLine("3. 저자로 검색");

    Console.Write("옵션을 선택하세요: ");
    int searchOption = Convert.ToInt32(Console.ReadLine());

    switch(searchOption) {
        case 1:
            searchManager.IdSearch();
            break;
        case 2:
            searchManager.TitleSearch();
            break;
        case 3:
            searchManager.AuthorSearch();
            break;
        default:
            Console.WriteLine("잘못된 선택입니다.");
            break;
    }
}

void DisplayAllBooks() {
    var books = bookManager.GetAllBooks();

    foreach(var book in books) {
        Console.WriteLine($"ID: {book.Id}, 제목: {book.Title}, 저자: {book.Author}");
    }
}