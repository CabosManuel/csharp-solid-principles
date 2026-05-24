using SingleResponsability;
using SingleResponsability.Helper;

StudentRepository studentRepository = new();

Exporter exporterCsv = new();
exporterCsv.ExportCsv(studentRepository.GetAll());

Console.WriteLine("Proceso Completado");