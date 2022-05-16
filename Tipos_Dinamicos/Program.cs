using System;

namespace Tipos_Dinamicos
{
    internal class Program


        //Clases anonimas se usan cuando no sabemos el tipo de dato o el tipo de respuesta que vamos a tener en un momento dado para poder tratar esa variable
    {
        static void Main(string[] args)
        {
            //Instancia normal,si avisa cuando por ejemplo un metodo necesita una n cantidad de parametros 
            ExampleClass exampleClass = new ExampleClass();

            //Al crear un tipo dinamico no se da cuenta de que un parametro por ejemplo necesita un n cantidad de parametros por lo cual
            //no avisa, pero se cae en tiempo de ejecucion
            dynamic dynamic_ec = new ExampleClass();
            dynamic_ec.exampleMethod1(10,4);

            //No da error con metodos que no existen, no hace comprobacion , solo los llama y se cae en ejecución
            dynamic_ec.someMethod("asasd",7,null);
            dynamic_ec.noExisteMethod();


        }




        class ExampleClass 
        {
          public ExampleClass() { }
          public ExampleClass(int v) { }
          public void exampleMethod1(int i) { }
          public void exampleMethod2(string str) { }



        }
    }
}
