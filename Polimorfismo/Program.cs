using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            gato.HacerRuido();

            Perro perro = new Perro();
            perro.HacerRuido();


            Lobo lobo = new Lobo();
            lobo.HacerRuido();

            Console.ReadLine();


            List<Animal> zoo = new List<Animal>();
            zoo.Add(gato);
            zoo.Add(perro);
            zoo.Add(lobo);


            foreach (var item in zoo)
            {
                item.HacerRuido();
            }

            Console.ReadLine();
        }
    }
}
