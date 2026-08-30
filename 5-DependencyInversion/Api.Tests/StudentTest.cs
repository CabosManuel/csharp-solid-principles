using Xunit;
using DependencyInversion.Controllers;
using Moq;
using DependencyInversion;

namespace Api.Tests;


public class StudentTest
{
    [Fact]
    public void GetStudent()
    {
        var LogbookMock = new Mock<ILogbook>();
        var stundentRepositoryMock = new Mock<IStudentRepository>();
        stundentRepositoryMock
            .Setup(p=> p.GetAll())
            .Returns(
                new List<Student>()
                {
                    new Student(1, "Pepito Pérez", new List<double>() { 3, 4.5 }),
                    new Student(2, "Mariana Lopera", new List<double>() { 4, 5 }),
                    new Student(3, "José Molina", new List<double>() { 2, 3 })
                }
            );

        var studentController = new StudentController(
            stundentRepositoryMock.Object,
            LogbookMock.Object
        );

        var resultGetStudents = studentController.Get();

        Assert.NotNull(resultGetStudents);
        Assert.Equal(3, resultGetStudents.Count());
    }

    [Fact]
    public void Add_NewStudent_CallsRepositoryAndLogbook()
    {
        var logBookMock = new Mock<ILogbook>();
        var studentRepositoryMock = new Mock<IStudentRepository>();

        var studentController = new StudentController(
            studentRepositoryMock.Object,
            logBookMock.Object
        );

        // El estudiante que se usará en el test
        Student newStudent = new Student(4, "Manuel Cabos", new List<double>() { 6, 7 });

        // Ejecuta el método
        studentController.Add(newStudent);

        // Verificar las interacciones ocurridas

        // ¿El controlador avisó al logbook exactamente una vez, con un mensaje
        // que contiene el Fullname del estudiante?
        logBookMock.Verify(
            s => s.Add(It.Is<string>(m => m.Contains(newStudent.Fullname))),
            Times.Once()
        );

        // ¿El controlador llamó al repositorio exactamente una vez,
        // con el mismo objeto Student que recibió?
        studentRepositoryMock.Verify(
            r => r.Add(newStudent),
            Times.Once()
        );
    }
}