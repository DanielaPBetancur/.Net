using System;

namespace MetodosAnonimos
{
    //Creacion del delegado

    delegate void Printer(string s);
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = DoWork;
            Printer printer2 = delegate (string K) { Console.WriteLine(K); };

            //Instancia el tipo delegado usando un metodo anonimo

            Printer p = delegate (string j) 
            {

                Console.WriteLine(j);
            
            };

            //Resultados de la llamada al delegado anonimo

            p("the delegate using the anonymous method is called");


            //la instanciacion de el delegado usando un metodo llamado DoWork
            p = DoWork;

            //Resultados desde la llamada del viejo estilo del delegado
            p("The delegate using the named method is called");
        }
    
     static void DoWork(string K) 
        {

            Console.WriteLine(K);
        
        }
    
    
    }


}
