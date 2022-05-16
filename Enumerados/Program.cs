using System;

namespace Enumerados
{
    class Program
    {

        static void PrintColor(Color color)
        {

            switch (color)
            {
                case Color.Rojo:
                    Console.WriteLine("Rojo");
                    break;
                case Color.Verde:
                    Console.WriteLine("Verde");
                    break;
                case Color.Azul:
                    Console.WriteLine("Azul");
                    break;
                default:
                    Console.WriteLine("Color desconocido");
                    break;
            }


        }

        static void Main(string[] args)
        {
            Color c = Color.Rojo;
            PrintColor(c);
            PrintColor(Color.Azul);

            int i = (int)Color.Azul;
            Color c2 = (Color)2;

            var alineacion = Alignment.Left;
        }
    }
}
