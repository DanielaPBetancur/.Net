using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();

            clase.Calcular(27);
          

            var suma =clase.Sumar(1,6);
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
