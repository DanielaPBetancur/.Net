using System;

namespace DeclararClases
{
    public class Clase
    {

        /*Las clases pueden tener:
        
        Propiedades

        Eventos

        Indizadores

        Operadores

        Constructores

        Destructores

        Tipos
         
         */

        //Constantes : variables cuyo valor no cambia

        const int IVA = 7;
        const int IVA7 = 7, IVA11 = 11, IVA21 = 21;

        private int Importe { get; set; }


        public int calcularImporte(int importe)
        {

            //IVA = 11; No se puede modificar
            return importe + (importe * IVA);

        }




    }
}
