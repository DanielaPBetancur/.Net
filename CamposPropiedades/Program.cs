using System;

namespace CamposPropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase clase = new Clase();
            //clase.Campo = 12;
            //clase.Apellidos = "Lopez Serrano";
            ////clase.Edad = 12;

            //Console.WriteLine(clase.Edad);
            //Console.ReadLine();


            Clase Clase2 = new Clase();

            //ASIGNACIONES
            var estado = Clase2.Estado;
            Clase2.Estado = 5;

            Console.WriteLine(Clase2.Edad);
            Clase2.Metodo(28);

            Console.WriteLine(Clase2.Edad);
            Console.ReadLine();
        }
    }
}
