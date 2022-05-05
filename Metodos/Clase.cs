using System;

namespace Metodos
{
    class Clase
    {

        //Campos o propiedades
        public int Campo;
        public string Nombre { get; set; }
        public readonly string Identificador = "XX";

        //Constructor

        public Clase()
        {



        }


        //Metodos
        public void Calcular(int edad)
        {
            //Operacion de nuestro metodo
            Console.WriteLine(edad+15);

        }


        public int Sumar(int numero,int numero2)
        {
            //Operacion de nuestro metodo
            return numero + numero2;

        }


    }
}
