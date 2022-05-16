using System;
using System.IO;

namespace LeerDatosDeUnStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            var capacidad = ms.Capacity;
            var longitud = ms.Length;
            var posicion = ms.Position;


            //Lugar donde se guardara la inf leida por el string
            byte[] buffer = new byte[50];

            ms.Read(buffer, 0, 5);
        }
    }
}
