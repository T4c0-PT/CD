using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    class triangulo
    {

        private float b;
        private float h;

        public triangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float Area() => b * h / 2;

    }
}
