using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Rectángulo : Figura
    {
        private float B;
        private float A;

        public Rectángulo(float B, float A)
        {
            this.B = B;
            this.A = A;
        }

        public override float CalculateArea()
        {
            return B * A;
        }
    }
}
