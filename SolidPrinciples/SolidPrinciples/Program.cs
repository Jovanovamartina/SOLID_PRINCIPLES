using SolidPrinciples.DependencyInversion;
using SolidPrinciples.InterfaceSegregation;
using SolidPrinciples.LiskovSubstitution;
using SolidPrinciples.OpenClosed;
using SolidPrinciples.SingleResponsibility;

Console.WriteLine("*************SINGLE RESPONSIBILITY*******************");
Console.WriteLine("\n");

var room = new HotelRoomSolid
{
    RoomNumber = 101
};

var bookingManager = new RoomBookingManager();

if (bookingManager.BookRoom(room))
{
    Console.WriteLine($"Room {room.RoomNumber} has been booked.");
}
else
{
    Console.WriteLine($"Room {room.RoomNumber} is already booked.");
}

if (bookingManager.CheckAvailability(room))
{
    Console.WriteLine($"Room {room.RoomNumber} is available.");
}
else
{
    Console.WriteLine($"Room {room.RoomNumber} is booked.");
}

var invoiceGenerator = new InvoiceGenerator();

string invoice = invoiceGenerator.GenerateInvoice(room);
if (!string.IsNullOrEmpty(invoice))
{
    Console.WriteLine(invoice);
}
else
{
    Console.WriteLine($"No invoice generated for Room {room.RoomNumber} as it is not booked.");
}

Console.WriteLine("\n");
Console.WriteLine("*************OPEN CLOSED*******************");
Console.WriteLine("\n");


var fullTimeEmployee = new FullTimeEmployee { HourlyRate = 20 };
var partTimeEmployee = new PartTimeEmployee { HourlyRate = 15, HoursWorked = 25 };
var intern = new Intern { HourlyRate = 10, HoursWorked = 30 };


Console.WriteLine($"Full-Time Employee Salary: ${fullTimeEmployee.CalculateSalary()}");
Console.WriteLine($"Part-Time Employee Salary: ${partTimeEmployee.CalculateSalary()}");
Console.WriteLine($"Intern Salary: ${intern.CalculateSalary()}");


Console.WriteLine("\n");
Console.WriteLine("*************LISKOV SUBSTITUTION*******************");
Console.WriteLine("\n");



IFruit apple = new AppleSolid();
IFruit orange = new OrangeSolid();

Console.WriteLine($"Apple color: {apple.GetColor()}");
Console.WriteLine($"Orange color: {orange.GetColor()}");


Console.WriteLine("\n");
Console.WriteLine("*************INTERFACE SEGREGATION*******************");
Console.WriteLine("\n");

var member = new Member();
var librarian = new Librarian();
var guest = new GuestSolid();

Console.WriteLine("Member Actions");
member.BorrowBook("123");
member.ReturnBook("123");
member.SearchCatalog("C# Programming");

Console.WriteLine("Librarian Actions");
var newBook = new BookSolid
{
    BookId = "456",
    Title = "Design Patterns",
    Author = "Erich Gamma",
    ISBN = "978-0-20163361-0"
};
librarian.BorrowBook("456");
librarian.ReturnBook("456");
librarian.SearchCatalog("Object-Oriented Design");
librarian.AddBook(newBook);
librarian.RemoveBook("456");

Console.WriteLine("Guest Actions");
guest.SearchCatalog("Java Programming");

Console.WriteLine("\n");
Console.WriteLine("*************DEPENDENCY INVERSION*******************");
Console.WriteLine("\n");


ISalaryCalculator salaryCalculatorr = new SalaryCalculatorModified();

var employeeDetails = new EmployeeDetailsModified(salaryCalculatorr)
{
    HoursWorked = 40,
    HourlyRate = 20
};

float salary = employeeDetails.GetSalary();
Console.WriteLine($"Employee Salary: ${salary}");