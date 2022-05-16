using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //Puede heredar solo una clase y n interfaces
    public class Car : IEquatable<Car> ,IComparacion
    {
        public bool Equals(Car obj)
        {
            throw new NotImplementedException();
        }

        public int EsIgual(int numero)
        {
            throw new NotImplementedException();
        }

        public int EsIgualaCoche(int numero)
        {
            throw new NotImplementedException();
        }
    }
}
