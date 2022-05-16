using System;
using System.IO;

namespace Seek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);
            var capacidad = ms.Capacity;  //Cuantos bytes puede almacenar el stream
            var longitud = ms.Length;     //tamaño de info actual que tiene el stram (La que esta usada)
            var posicion = ms.Position;   


            ms.Seek(0, SeekOrigin.Begin);
            ms.Seek(10, SeekOrigin.Begin);
            ms.Seek(-10, SeekOrigin.Begin);


            ms.Seek(5, SeekOrigin.Current);
            ms.Seek(-10, SeekOrigin.Current);
        }
    }
}
