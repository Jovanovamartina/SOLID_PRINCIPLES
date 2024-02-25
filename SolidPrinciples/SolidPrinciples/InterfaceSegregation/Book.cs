
namespace SolidPrinciples.InterfaceSegregation
{

    public class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
    }

    public interface IUser
    {
        void BorrowBook(string bookId);
        void ReturnBook(string bookId);
        void SearchCatalog(string searchTerm);
        void AddBook(Book book);
        void RemoveBook(string bookId);
    }

    public class Guest : IUser
    {
        public void BorrowBook(string bookId)
        {
            throw new NotImplementedException("Guests cannot borrow books.");
        }

        public void ReturnBook(string bookId)
        {
            throw new NotImplementedException("Guests cannot return books.");
        }

        public void SearchCatalog(string searchTerm)
        {
            Console.WriteLine($"Member Search Book: {searchTerm}");
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException("Guests cannot add books.");
        }

        public void RemoveBook(string bookId)
        {
            throw new NotImplementedException("Guests cannot remove books.");
        }
    }
}

