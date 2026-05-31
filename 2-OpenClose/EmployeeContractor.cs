namespace OpenClose;

public class EmployeeContractor: Employee
{
    public EmployeeContractor(string fullname, int hoursWorked)
        :base(fullname, hoursWorked)
    {
        Fullname = fullname;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalaryMonthly()
    {
        decimal hourValue = 40000M;
        decimal salary = HoursWorked * hourValue;

        return salary;
    }
}