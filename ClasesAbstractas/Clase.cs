using System;

namespace ClasesAbstractas
{
    public abstract class Clase : ClaseAbstracta
    {
        public override int Sumar(int i, int z)
        {
            return i + z;
        }

        public abstract override int Restar(int i, int z);
    }
}
