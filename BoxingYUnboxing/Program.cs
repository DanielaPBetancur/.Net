using System;

namespace BoxingYUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;

            //Boxing es copiar el valor del entero de i al objeto 0
           object o = 1;

            o = 456;
            i=(int)o; //unboxing


            int i2 = 123;
            object o2 = i; //Implicit boxing

            try
            {
                int j = (short)o2; // intento de unbox

                System.Console.WriteLine("Unboxing OK");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error : Incorrect unboxing",e.Message);
                
            }
        }
    }
}
