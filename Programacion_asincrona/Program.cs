using System;
using System.Threading.Tasks;

namespace Programacion_asincrona
{
    internal class Program
    {
        internal class Cafe
        {
            public Cafe()
            {
            }

        }

        //Son tareas que devuelven algo asi que ya no va void sino task
        static async Task Main(string[] args)
        {
            Cafe cup = HacerCafe();
            Console.WriteLine("Cafe listo");
            Huevos eggs = await FreirHuevos(2);
            Console.WriteLine("Huevos listos");
            Bacon bacon = await FreirBacon(3);
            Console.WriteLine("Bacon listos");
            Tostada toast = await TostarPan(2);
            AplicarMantequilla(toast);
            AplicarJamon();
            Console.WriteLine("Tostadas preparadas");
            Zumo oj = HacerZumo();
            Console.WriteLine("Zumo listo");
            Console.WriteLine("Desayuno listo!");
        }

        public static Cafe HacerCafe()
        {

            return new Cafe();

        }

        public class Bacon
        {
        }

        public class Zumo
        {

        }


        public class Tostada
        {
            public Tostada()
            {
            }

        }

        public class Mantequilla
        {
        }

        public class Huevos
        {
        }

        public class Jamon
        {
        }


        public static async Task<Huevos> FreirHuevos(int numHuevos)
        {

            return new Huevos();

        }

        public static async Task<Bacon> FreirBacon(int numHuevos)
        {

            return new Bacon();

        }

        public static async Task<Tostada> FreirTostada(int numHuevos)
        {

            return new Tostada();

        }


        public static async Task<Tostada> TostarPan(int numHuevos)
        {

            return new Tostada();

        }

        public static Mantequilla AplicarMantequilla(Tostada tostada)
        {

            return new Mantequilla();

        }
        public static Jamon AplicarJamon()
        {

            return new Jamon();

        }
        public static Zumo HacerZumo()
        {

            return new Zumo();

        }

    }


}




