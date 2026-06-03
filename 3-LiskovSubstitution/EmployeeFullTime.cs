namespace Liskov;

public class EmployeeFullTime : Employee
{
    public int ExtraHours {get; set;}

    public EmployeeFullTime(
        string fullname,
        int hoursWorked,
        int extrahours,
        int hourValue = 50
    ) :base(fullname, hoursWorked, hourValue)
    {
        ExtraHours = extrahours;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary()
    {
        return HourValue * (HoursWorked + ExtraHours);
    }
}