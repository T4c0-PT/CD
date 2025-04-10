using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    class Cuadrado
    {
        private float l1;
        private float l2;

        public Cuadrado(float l1, float l2)
        {
            this.l1 = l1;
            this.l2 = l2;
        }

        public float Area() => l1 * l2;

    }
}
