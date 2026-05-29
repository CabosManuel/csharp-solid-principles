namespace OpenClose;

public class EmployeeContractor: Employee, IEmployee
{
    public EmployeeContractor(string fullname, int hoursWorked)
        :base(fullname, hoursWorked)
    {
        Fullname = fullname;
        HoursWorked = hoursWorked;
    }

    public decimal CalculateSalaryMonthly()
    {
        decimal hourValue = 40000M;
        decimal salary = HoursWorked * hourValue;

        return salary;
    }
}