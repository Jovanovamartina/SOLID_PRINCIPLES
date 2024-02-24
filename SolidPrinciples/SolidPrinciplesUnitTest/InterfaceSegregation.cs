using SolidPrinciples.InterfaceSegregation;


namespace SolidPrinciplesUnitTest
{
    [TestClass]
    public class InterfaceSegregation
    {
        [TestMethod]
        public void Member_BorrowBook()
        {
            // Arrange
            Member member = new Member();
            string bookId = "123";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                member.BorrowBook(bookId);
                string result = sw.ToString().Trim();

                // Assert
                Assert.AreEqual($"Member Borrow Book, BookId: {bookId}", result);
            }
        }

        [TestMethod]
        public void Librarian_AddBook_()
        {
            // Arrange
            Librarian librarian = new Librarian();
            BookSolid book = new BookSolid
            {
                BookId = "456",
                Title = "The Art of Unit Testing",
                Author = "Roy Osherove",
                ISBN = "9781933988276"
            };

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                librarian.AddBook(book);
                string result = sw.ToString().Trim();

                // Assert
                Assert.AreEqual($"Librarian Add Book, {book}", result);
            }
        }

        [TestMethod]
        public void Guest_SearchCatalog()
        {
            // Arrange
            GuestSolid guest = new GuestSolid();
            string expectedOutput = $"Guest Search Book: Unit Testing"; // Update expected output

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                guest.SearchCatalog("Unit Testing");
                string actualOutput = sw.ToString().Trim();

                // Assert
                Assert.AreEqual(expectedOutput, actualOutput);
            }
        }
    }
}



