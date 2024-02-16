
namespace SolidPrinciples.OpenClosed
{
        public enum EmployeeType
        {
            FullTime,
            PartTime,
            Intern
        }

        public class Employee
        {
            public EmployeeType Type { get; set; }
            public double HourlyRate { get; set; }
            public double HoursWorked { get; set; }
        }

        public class SalaryCalculator
        {
            public double CalculateSalary(Employee employee)
            {
                switch (employee.Type)
                {
                    case EmployeeType.FullTime:
                        return employee.HourlyRate * 160;  // Assuming 160 work hours in a month
                    case EmployeeType.PartTime:
                        return employee.HourlyRate * employee.HoursWorked;
                    case EmployeeType.Intern:
                        return employee.HourlyRate * employee.HoursWorked * 0.5; // Interns get 50% of their computed salary
                    default:
                        throw new ArgumentException("Invalid employee type");
                }
            }
        }
    }

