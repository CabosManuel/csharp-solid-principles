namespace OpenClose;

public class EmployeePartTime: Employee
{
    public EmployeePartTime(string fullname, int hoursWorked)
        : base(fullname, hoursWorked)
    {
        Fullname = fullname;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalaryMonthly()
    {
        decimal hourValue = 20000M;
        decimal salary = HoursWorked * hourValue;

        if (HoursWorked > 160) {
            decimal effortCompensation = 5000M;
            int extraDays = HoursWorked - 160;
            salary += effortCompensation * extraDays;
        }

        return salary;
    }
}