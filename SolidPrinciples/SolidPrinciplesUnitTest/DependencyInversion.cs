using SolidPrinciples.DependencyInversion;


namespace SolidPrinciplesUnitTest
{
    [TestClass]
    public class DependencyInversion
    {
        [TestMethod]
        public void GetSalary_Calculator()
        {
            // Arrange
            int hoursWorked = 40;
            int hourlyRate = 15;
            ISalaryCalculator salaryCalculator = new SalaryCalculatorModified();
            EmployeeDetailsModified employee = new EmployeeDetailsModified(salaryCalculator);

            // Act
            employee.HoursWorked = hoursWorked;
            employee.HourlyRate = hourlyRate;
            float result = employee.GetSalary();

            // Assert
            float expectedSalary = hoursWorked * hourlyRate;
            Assert.AreEqual(expectedSalary, result);
        }

        [TestMethod]
        public void GetSalary_ZeroHoursWorked()
        {
            // Arrange
            int hoursWorked = 0;
            int hourlyRate = 20;
            ISalaryCalculator salaryCalculator = new SalaryCalculatorModified();
            EmployeeDetailsModified employee = new EmployeeDetailsModified(salaryCalculator);

            // Act
            employee.HoursWorked = hoursWorked;
            employee.HourlyRate = hourlyRate;
            float result = employee.GetSalary();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetSalary_ZeroHourlyRate()
        {
            // Arrange
            int hoursWorked = 30;
            int hourlyRate = 0;
            ISalaryCalculator salaryCalculator = new SalaryCalculatorModified();
            EmployeeDetailsModified employee = new EmployeeDetailsModified(salaryCalculator);

            // Act
            employee.HoursWorked = hoursWorked;
            employee.HourlyRate = hourlyRate;
            float result = employee.GetSalary();

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
