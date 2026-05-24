using OpenClose;
using System.Globalization;

// Actualizar la configuración regional para mostrar el formato de moneda en soles peruanos
CultureInfo.CurrentCulture = new CultureInfo("es-PE");

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmployeeContractor("Manuel Cabos", 160)
});


void CalculateSalaryMonthly(List<Employee> employees)
{
    foreach (var employee in employees)
        Console.WriteLine($"Empleado: {employee.Fullname}, Pago: {employee.CalculateSalaryMonthly():C2} ");
}