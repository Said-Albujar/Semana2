using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Circulo : Figura
    {
        private float radius;

        public Circulo(float radius)
        {
            this.radius = radius;
        }

        public override float CalculateArea()
        {
            return radius * radius * 3.14f;
        }
    }
}
