using System;
using System.Threading.Tasks;

namespace Composicion_de_tareas
{
    internal class Program
    {
        public class Cafe { }
        public class Huevos { }
        public class Bacon { }
        public class Tostada { }
        public class Zumo { }
        public class Jamon { }
        public class Mantequilla { }

        static async Task Main(string[] args)
        {

            Cafe cup = HacerCafe();
            Console.WriteLine("Cafe listo");
            Task<Huevos> eggsTask = FreirHuevos(2);
            Task<Bacon> baconTask = FreirBacon(3);


            var toastTask = HacerTostadasConMantequillaYJamon(2);

            Zumo oj = HacerZumo();
            Console.WriteLine("Zumo listo");

            Huevos eggs = await eggsTask;
            Console.WriteLine("Huevos listos");


            Bacon bacon = await baconTask;
            Console.WriteLine("Bacon listos");

            Tostada tostada = await toastTask;

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

        public static Jamon AplicarJamon(Tostada plainToast)
        {

            return new Jamon();

        }

        async static  Task<Tostada> HacerTostadasConMantequillaYJamon(int number)
        {

            var plainToast = await TostarPan(number);
            AplicarMantequilla(plainToast);
            AplicarJamon(plainToast);
            return plainToast;

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


        public static async Task AplicarMantequilla(Tostada tostada)
        {



        }

        public static async Task<Tostada> TostarPan(int numHuevos)
        {

            return new Tostada();

        }
    }
}

