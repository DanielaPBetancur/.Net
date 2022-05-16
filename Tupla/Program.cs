using System;

namespace Tupla
{
     class Program
    {
        static void Main(string[] args)
        {
            //Formas de crear tuplas


            //Forma1 :
           var tupla = new Tuple<int, string, string, DateTime>(1,"Daniela","Alejandra",DateTime.Now);

            //Forma2

            var tupl2 = Tuple.Create(1,"Daniela", "Alejandra",DateTime.Now);


            //Forma3

            var ejemplo = Ejemplo();

            var entero = ejemplo.Item1;
            var nombre = ejemplo.Item2;
        }

        public static Tuple<int, string, string, DateTime> Ejemplo() 
        {

            return new Tuple<int, string, string, DateTime>(1, "Daniela", "Alejandra", DateTime.Now);
        
        }


    }
}
