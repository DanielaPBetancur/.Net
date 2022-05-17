using System;
using System.Threading.Tasks;

namespace Inicio_simultaneo_de_tareas
{
    public class Cafe { }
    public class Huevos { }
    public class Bacon { }
    public class Tostada { }
    public class Zumo { }
    public class Jamon { }
    public class Mantequilla { }

     class Program
    {
        //static async Task Main(string[] args)
        //{

        //    Cafe cup = HacerCafe();
        //    Console.WriteLine("Cafe listo");
        //    Task<Huevos> eggsTask =FreirHuevos(2);
        //    Huevos eggs = await eggsTask;
        //    Console.WriteLine("Huevos listos");

        //    Task<Bacon> baconTask = FreirBacon(3);
        //    Bacon bacon = await baconTask;
        //    Console.WriteLine("Bacon listos");


        //    Task<Tostada> toastTask = TostarPan(2);
        //    Tostada toast = await toastTask;    

        //    await AplicarMantequilla(toast);
        //    aplicarJamon(toast);
        //    Console.WriteLine("Tostadas preparadas");
        //    Zumo oj = HacerZumo();
        //    Console.WriteLine("Zumo listo");
        //    Console.WriteLine("Desayuno listo!");
        //}

        static async Task Main(string[] args)
        {

            Cafe cup = HacerCafe();
            Console.WriteLine("Cafe listo");
            Task<Huevos> eggsTask = FreirHuevos(2);
            Task<Bacon> baconTask = FreirBacon(3);


            Task<Tostada> toastTask = TostarPan(2);
            Tostada toast = await toastTask;

            await AplicarMantequilla(toast);
            aplicarJamon(toast);
            Console.WriteLine("Tostadas preparadas");
            Zumo oj = HacerZumo();
            Console.WriteLine("Zumo listo");

            Huevos eggs = await eggsTask;
            Console.WriteLine("Huevos listos");

           
            Bacon bacon = await baconTask;
            Console.WriteLine("Bacon listos");


            Console.WriteLine("Desayuno listo!");
        }

        private static void aplicarJamon(Tostada toast)
        {
            throw new NotImplementedException();
        }

        public static Cafe HacerCafe()
        {

            return new Cafe();

        }

        public static Zumo HacerZumo()
        {

            return new Zumo();

        }

        public static Jamon AplicarJamon()
        {

            return new Jamon();

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


        public static async Task AplicarMantequilla (Tostada tostada)
        {

            

        }

        public static async Task<Tostada> TostarPan(int numHuevos)
        {

            return new Tostada();

        }
    }
}
