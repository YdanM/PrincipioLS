using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLS
{
    public class OnsiteCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"El estudiante {student.Nombre} se ha suscrito al curso presencial {Title}.");
        }

        public override string Cupo()
        {
            return $"Cupos Presenciales: {Limit}";

        }
    }
}
