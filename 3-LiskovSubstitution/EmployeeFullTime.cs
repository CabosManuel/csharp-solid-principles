namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours {get; set;}

        public EmployeeFullTime(
            string fullname,
            int hoursWorked,
            int extrahours,
            int hourValue = 50
        ) :base(fullname, hoursWorked)
        {
            ExtraHours = extrahours;
            HoursWorked = hoursWorked;
        }
    }
}