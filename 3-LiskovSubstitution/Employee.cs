namespace Liskov;

public abstract class Employee
{
    public string Fullname { get; set; }
    public int HoursWorked { get; set; }
    public int HourValue {get; set;}

    public  Employee(
        string fullname,
        int hoursWorked,
        int hourValue
    ) {
        Fullname = fullname;
        HoursWorked = hoursWorked;
        HourValue = hourValue;
    }

    public abstract decimal CalculateSalary();
}