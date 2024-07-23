using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLS
{
    public class HybridCourse : Course
    {
        private readonly OnlineCourse _onlineCourse;
        private readonly OnsiteCourse _onsiteCourse;

        public HybridCourse(int courseId, string title, OnlineCourse onlineCourse, OnsiteCourse onsiteCourse, int limit)
        {
            CourseId = courseId;
            Title = title;
            _onlineCourse = onlineCourse;
            _onsiteCourse = onsiteCourse;
            Limit = limit;
        }

        public override void Subscribe(Student student)
        {
            Console.WriteLine($"El estudiante {student.Nombre} se ha suscrito al curso híbrido {Title}.");
            _onlineCourse.Subscribe(student);
            _onsiteCourse.Subscribe(student);
        }

        public override string Cupo()
        {
            return $"Cupos Hibridos: {Limit} \n{_onlineCourse.Cupo()} \n{_onsiteCourse.Cupo()}";
        }
    }
}
