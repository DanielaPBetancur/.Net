using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prog_Asinc_mejores_practicas
{
    public class Cafe { }
    public class Huevos { }
    public class Bacon { }
    public class Tostada { }
    public class Zumo { }
    public class Jamon { }
    public class Mantequilla { }
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Cafe cup = HacerCafe();
            Console.WriteLine("Cafe listo");
            var eggsTask = FreirHuevos(2);
            var baconTask = FreirBacon(3);
            var toastTask = HacerTostadasConMantequillaYJamon(2);

            var allTasks = new List<Task> { eggsTask, baconTask, toastTask };

            while (allTasks.Any())
            {
                Task finished = await Task.WhenAny(allTasks);
                if (finished == eggsTask)
                {
                    Console.WriteLine("Huevos listos");
                    allTasks.Remove(eggsTask);
                    var eggs = await eggsTask;
                }
                else if (finished == baconTask)
                {
                    Console.WriteLine("Bacon listos");
                    allTasks.Remove(baconTask);
                    var bacon = await baconTask;
                }
                else if (finished == toastTask)
                {
                    Console.WriteLine("Tostadas listas");
                    allTasks.Remove(toastTask);
                    var toast = await toastTask;
                }
                else
                {
                    allTasks.Remove(finished);

                }

                Console.WriteLine("Desayuno listo!");

            }

            //Zumo oj = HacerZumo();
            //Console.WriteLine("Zumo listo");

            //await Task.WhenAll(eggsTask, baconTask, toastTask); 
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

        async static Task<Tostada> HacerTostadasConMantequillaYJamon(int number)
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

