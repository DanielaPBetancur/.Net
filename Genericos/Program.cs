using System;

namespace Genericos
{

    //Declarando clase generica, al ser generico no sabes de que tipo de dato te van a pasar
    public class GenericList<T>
    {
        public void add(T input) { }
    }

    class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {
            //Declaro una lista de tipo entero

            GenericList<int> lista1 = new GenericList<int>();
            lista1.add(1);


            //Declaro una lista de tipo string

            GenericList<string> lista2 = new GenericList<string>();
            lista2.add("a");


            //Declaro una lista de tipo ExampleClass

            GenericList<ExampleClass> lista3 = new GenericList<ExampleClass>();
            lista3.add(new ExampleClass());


            Ejemplo<int>(7);
            Ejemplo<string>("Hola");
            Ejemplo<DateTime>(DateTime.Now);

        }

        //Metodo generico, siempre será el mismo que el que le estamos especificando al metodo
        public static void Ejemplo<T>(T tipo)
        {
            Console.WriteLine(tipo);

        }

    }
}

       

      
