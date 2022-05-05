using System;

namespace clases_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Creando objetos de clase cuenta bancaria
            CuentaBancaria cuenta1 = new CuentaBancaria();
            cuenta1.saldo = 1500;


            CuentaBancaria cuenta2 = new CuentaBancaria();
            cuenta2.saldo = 2200;


            int suma = cuenta1.saldo + cuenta2.saldo;
        }
    }
}
