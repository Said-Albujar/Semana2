using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Cuadrado : Figura
    {
        private float L;
       

        public cuadrado(float L)
        {
            this.L = L;

        }

        public override float CalculateArea()
        {
            return L * L;
        }
    }
}
