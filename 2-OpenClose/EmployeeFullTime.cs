namespace OpenClose;

public class EmployeeFullTime: Employee, IEmployee
{
    public EmployeeFullTime(string fullname, int hoursWorked)
        :base(fullname, hoursWorked)
    {
        Fullname = fullname;
        HoursWorked = hoursWorked;
    }

    public decimal CalculateSalaryMonthly()
    {
        decimal hourValue = 30000M;
        decimal salary = HoursWorked * hourValue;

        return salary;
    }
}