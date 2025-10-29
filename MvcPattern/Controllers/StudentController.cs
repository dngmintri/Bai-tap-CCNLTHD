
using Microsoft.AspNetCore.Mvc;
public class StudentController : Controller
{
    public IActionResult Index()
    {
        List<Student> students = new List<Student>
        {
            new Student{Id = 1, Name = "Ba Phong", Major = "Cong Nghe Thong Tin"},
            new Student{Id = 2, Name = "Phong Luu", Major = "Cong Nghe Thong Tin"},
            new Student{Id = 3, Name = "Dang Khoa", Major = "Cong Nghe Thong Tin"},
            new Student{Id = 4, Name = "Duong Minh Tri", Major = "Cong Nghe Thong Tin"},
        };

        return View(students);
    }
}