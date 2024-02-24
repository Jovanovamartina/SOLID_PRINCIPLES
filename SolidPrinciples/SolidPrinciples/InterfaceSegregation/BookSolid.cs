
namespace SolidPrinciples.InterfaceSegregation
{

        public class BookSolid
        {
            public string? BookId { get; set; }
            public string? Title { get; set; }
            public string? Author { get; set; }
            public string? ISBN { get; set; }

            public override string ToString()
            {
                return $"[BookId: {BookId}, Title: {Title}, Author:{Author}, ISBN:{ISBN}]";
            }
        }

        public interface IBorrowReturn
        {
            void BorrowBook(string bookId);
            void ReturnBook(string bookId);
        }

        public interface ISearchable
        {
            void SearchCatalog(string searchTerm);
        }

        public interface IManageInventory
        {
            void AddBook(BookSolid book);
            void RemoveBook(string bookId);
        }

        public class Member : IBorrowReturn, ISearchable
        {
            public void BorrowBook(string bookId)
            {
                Console.WriteLine($"Member Borrow Book, BookId: {bookId}");
            }

            public void ReturnBook(string bookId)
            {
                Console.WriteLine($"Member Return Book, BookId: {bookId}");
            }

            public void SearchCatalog(string searchTerm)
            {
                Console.WriteLine($"Member Search Book: {searchTerm}");
            }
        }

        public class Librarian : IBorrowReturn, ISearchable, IManageInventory
        {
            public void BorrowBook(string bookId)
            {
                Console.WriteLine($"Librarian Borrow Book, BookId: {bookId}");
            }

            public void ReturnBook(string bookId)
            {
                Console.WriteLine($"Librarian Return Book, BookId: {bookId}");
            }

            public void SearchCatalog(string searchTerm)
            {
                Console.WriteLine($"Librarian Search Book: {searchTerm}");
            }

            public void AddBook(BookSolid book)
            {
                Console.WriteLine($"Librarian Add Book, {book}");
            }

            public void RemoveBook(string bookId)
            {
                Console.WriteLine($"Librarian Remove Book, BookId: {bookId}");
            }
        }

        public class GuestSolid : ISearchable
        {
            public void SearchCatalog(string searchTerm)
            {
                Console.WriteLine($"Guest Search Book: {searchTerm}");
            }
        }
    }


      

