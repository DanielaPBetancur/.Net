using System;

namespace NivelesDeAccesos
{
    class ClaseBase
    {
        public string Telefono { get; set; }
        private int Edad { get; set; } //Solamente se puede ver desde la misma clase o estructura, cualquier metodo dentro d esa clase
        internal string Nombre { get; set; } //Solo puede tener acceso al tipo o miembro del mismo ensamblado pero no distintos

        protected string Apellidos { get; set; } // Solo puede acceder al código de la misma clase o codigo de una clase derivada de esta
        protected internal string Nacionalidad { get; set; } //pueden acceder solo en el mismo ensamblado


        public ClaseBase() 
        {

            Edad = 16;
          Apellidos = "Lopez";
        
        }

        private void Sumar(int a , int b) 
        {
        
         
        
        }
    }
}
