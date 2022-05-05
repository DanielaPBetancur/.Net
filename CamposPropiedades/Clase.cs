using System;

namespace CamposPropiedades
{
    class Clase
    {
        //Propiedades o campos, son miembros de datos de una clase , gestionan el estado de la clase

        public int Campo;
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; private set; }

        public int Estado = 1;


        //Campos de solo lectura

        public readonly string Identificador;


        //Constructor
        public Clase()
        {

            Identificador = "ABCD";
            Edad = 10 ;
        }

        public void Metodo(int edad)
        {

            if (edad > 18)

            {
                Edad = edad;

            }

            //Identificador = "XXX";
        }



    }
}