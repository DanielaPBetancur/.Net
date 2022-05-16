using System;

namespace ClasesAbstractas
{

    //No se pueden crear istancias de una clase abstracta . su proposito es utilizar por ejemplo un parametro para muchas subfunciones
    public abstract class ClaseAbstracta
    {
        public abstract int Sumar(int i, int z);

        public virtual int Restar(int i, int z) 
        {
            return i - z;
        }
    }
}
