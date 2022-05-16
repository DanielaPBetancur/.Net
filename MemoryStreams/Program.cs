using System;
using System.IO;

namespace MemoryStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            //MemoryStream lleva info de un lugar a otro
            MemoryStream ms = new MemoryStream(150);

            //Los datos que se pueden obtener son
            var capacidad = ms.Capacity;  //Cuantos bytes puede almacenar el stream
            var longitud = ms.Length;     //tamaño de info actual que tiene el stram (La que esta usada)
            var posicion = ms.Position;   //Lugar donde se encentra el byte actual(el sgte a ser procesado)

        }
    }
}
