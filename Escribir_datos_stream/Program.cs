using System;
using System.IO;
using System.Text;

namespace Escribir_datos_stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream(150);
            var capacidad = ms.Capacity;  //Cuantos bytes puede almacenar el stream
            var longitud = ms.Length;     //tamaño de info actual que tiene el stram (La que esta usada)
            var posicion = ms.Position;


            byte[] miBuffer = new byte[50];

            ms.Write(miBuffer, 0, 15);
            ms.Close();

            //Ejemplo

            MemoryStream memStream = new MemoryStream(50);
            string miInformacion = string.Empty;

            var capacidad2 = memStream.Capacity;  
            var longitud2 = memStream.Length;    
            var posicion2 = memStream.Position;

            byte[] buffer = new byte[50];


            //El usuario da datos

            Console.WriteLine("Introduce la Informacion");
            miInformacion = Console.ReadLine();


            memStream.Write(ASCIIEncoding.ASCII.GetBytes(miInformacion),0,miInformacion.Length);
            memStream.Seek(0,SeekOrigin.Begin);
            memStream.Read(buffer,0,5);


            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            memStream.Close();

        }
    }
}
