using System;

namespace Delegados
{
    //Declaracion de delegados

    public delegate void Del(string message );
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar el delegado
            Del handler = DelegateMethod;

            //llamar al delegado

            handler("Hello world");


            MethodWithCallback(1, 2, handler);

            MethodClass obj = new MethodClass();

            Del d1 = obj.Method1;
            Del d2 = obj.Method2;
            Del d3 = DelegateMethod;


            //ambos tipos de asignacion son validos

            Del allMethodsDelegate = d1 + d2;
            allMethodsDelegate += d3;

            //allMethodsDelegate = ("Llamando a delegados");


            //Remove method1
            allMethodsDelegate -= d1;


            //allMethodsDelegate = ("Llamando a delegados");

        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);


        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {

            callback("The number is: " + (param1 + param2).ToString());
        }


        public class MethodClass
        {
           public void Method1(string message) { }
           public void Method2(string message) { }

        }
    }
}
