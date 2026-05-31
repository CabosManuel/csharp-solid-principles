namespace OpenClose;

public abstract class Employee(string fullname, int hoursWorked): IEmployee
{
    public string Fullname { get; set; } = fullname;
    public int HoursWorked { get; set; } = hoursWorked;

    public abstract decimal CalculateSalaryMonthly();
}