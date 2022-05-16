using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IEquatable<T>
    {
        //Solo incluyen definiciones de la implementacion no implementaciones en si

        //Definiciones que se debe tener todo el que herede de esta interfaz
        bool Equals(T obj);
        int EsIgual(int numero);
    }

    interface IComparacion
    {
        int EsIgualaCoche(int numero);
    }
}
