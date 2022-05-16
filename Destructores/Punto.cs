
using System;
using System.Collections.Generic;
using System.Text;

namespace Destructores
{
    class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto()
        {
            X = 0;
            Y = 0;
        }
        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Virguilla
        //Solo se puede tener uno por cada clase
        //No se puede llamar al destructor, es automatico , no es algo que se suele utilizar
        ~Punto()
        {
            X = 0;
            Y = 0;
        }
    }
}
