using System;
using System.IO;

namespace Intro_Archvos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Modos de como se puede usar:
            
            FileMode.Append         si existe se abre 
            FileMode.Create         crea nuevo archivo, si ya existe se sobreescribe
            FileMode.CreateNew      crea nuevo archivo, si ya existe se produce excepcion
            FileMode.Open           Abre archivo que ya existe, si tratamos de abrir uno que no existe produce excepcion
            FileMode.OpenOrCreate   si existe se abre , si no existe se crea
            FileMode.Truncate       Abre archivo , entonces los contenidos se eliminan hasta que el archivo tenga una long. de 0 bytes
           
             */

            FileStream fs = new FileStream("miArchivo.txt", FileMode.Create);


        }
    }
}
