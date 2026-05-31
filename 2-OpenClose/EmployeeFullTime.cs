namespace OpenClose;

public class EmployeeFullTime: Employee
{
    public EmployeeFullTime(string fullname, int hoursWorked)
        :base(fullname, hoursWorked)
    {
        Fullname = fullname;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalaryMonthly()
    {
        decimal hourValue = 30000M;
        decimal salary = HoursWorked * hourValue;

        return salary;
    }
}