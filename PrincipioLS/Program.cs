using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var onlineCourse = new OnlineCourse { CourseId = 1, Title = "Curso de C# en Línea", Limit = 30 };
            var onsiteCourse = new OnsiteCourse { CourseId = 2, Title = "Curso de C# Presencial", Limit = 30 };
            var hybridCourse = new HybridCourse(3, "Curso de C# Híbrido", onlineCourse, onsiteCourse, 60);

            var student = new Student { Id = 1, Nombre = "Ydan Monegro" };

            List<Course> courses = new List<Course> { onlineCourse, onsiteCourse, hybridCourse };

            foreach (var course in courses)
            {
                course.Subscribe(student);
                Console.WriteLine(course.Cupo());
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
