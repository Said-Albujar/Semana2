﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectángulo rectangulo = new Rectángulo(5, 3);


            Console.WriteLine($"Rectangulo: {rectangulo.CalculateArea()}");
        }
    }
}
