using System;
using System.IO;
using System.Text;

namespace Escribir_datos_archivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("miArchivo.txt", FileMode.Append);

            string cadena = "Esto es una cadena añadida";

            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena),0,cadena.Length);
            fs.Close();
        }
    }
}
