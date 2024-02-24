using SolidPrinciples.OpenClosed;

namespace SolidPrinciplesUnitTest
{
    [TestClass]
    public class OpenClosed
    {
        [TestMethod]
        public void TestFullTimeEmployeeSalary()
        {
            // Arrange
            var fullTimeEmployee = new FullTimeEmployee
            {
                HourlyRate = 20
            };

            // Act
            double salary = fullTimeEmployee.CalculateSalary();

            // Assert
            Assert.AreEqual(20 * 160, salary);
        }

        [TestMethod]
        public void TestPartTimeEmployeeSalary()
        {
            // Arrange
            var partTimeEmployee = new PartTimeEmployee
            {
                HourlyRate = 15,
                HoursWorked = 25
            };

            // Act
            double salary = partTimeEmployee.CalculateSalary();

            // Assert
            Assert.AreEqual(15 * 25, salary);
        }

        [TestMethod]
        public void TestInternSalary()
        {
            // Arrange
            var intern = new Intern
            {
                HourlyRate = 18,
                HoursWorked = 30
            };

            // Act
            double salary = intern.CalculateSalary();

            // Assert
            Assert.AreEqual(18 * 30 * 0.5, salary);
        }
    }
}
