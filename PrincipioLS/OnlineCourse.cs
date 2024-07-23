﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioLS
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student student)
        {
            Console.WriteLine($"El estudiante {student.Nombre} se ha suscrito al curso en línea {Title}.");
        }

        public override string Cupo()
        {
            return $"Cupos en Linea: {Limit}";
        }
    }
}
