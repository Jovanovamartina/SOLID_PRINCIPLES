
namespace SolidPrinciples.OpenClosed
{
    public interface IEmployee
    {
        double CalculateSalary();
    }

  

    public class FullTimeEmployee : IEmployee
    {
        public double HourlyRate { get; set; }

        public double CalculateSalary()
        {
            return HourlyRate * 160;
        }
    }

    public class PartTimeEmployee : IEmployee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }

    public class Intern : IEmployee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public double CalculateSalary()
        {
            return HourlyRate * HoursWorked * 0.5;
        }
    }

    public class SalaryCalculatorSolid
    {
        public double CalculateSalary(IEmployee employee)
        {
            return employee.CalculateSalary();
        }
    }


}

