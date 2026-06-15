using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    IStudentRepository studentRepository;
    ILogbook logbookRepository;

    public StudentController (
        IStudentRepository studentRepository,
        ILogbook logbookRepository
    ) {
        this.studentRepository = studentRepository;
        this.logbookRepository = logbookRepository;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbookRepository.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody]Student student)
    {
        studentRepository.Add(student);
        logbookRepository.Add($"The Student {student.Fullname} have been added");
    }
}
