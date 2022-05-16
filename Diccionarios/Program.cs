using System;
using System.Collections.Generic;

namespace Diccionarios
{
     class Program
    {
        static void Main(string[] args)
        {
            //Creación del diccionario, sirve para hacer inserciones en BDS o inserciones, o busquedas masivas
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("txt","notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");


            string valor = string.Empty;

            openWith.TryGetValue("dib", out valor);

            var ejemplo1 = openWith["rtf"];

            if (!openWith.ContainsKey("doc"))
            {
                openWith.Add("doc", "win.exe");
            }

            openWith["doc"] = "winword.exe";


            //recorrer el diccionario
            foreach (var kvp in openWith)
            {
                Console.WriteLine("Key ={0} , Value ={1}",
                    kvp.Key,kvp.Value);
            }

            //Obtener las keys
            Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;


            //Eliminar 

            openWith.Remove("doc");


            //Foreach para revisar que ha eliminado la clave

            foreach (var kvp in openWith)
            {
                Console.WriteLine("Key ={0} , Value ={1}",
                    kvp.Key, kvp.Value);
            }

        }
    }
}
