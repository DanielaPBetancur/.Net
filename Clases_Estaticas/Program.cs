using System;
using System.Collections.Generic;

namespace Clases_Estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = new ClassConInstancia();
            instance1.InstanceProperty = 1;

            var instance2 = new ClassConInstancia();
            instance2.InstanceProperty = 2;

            instance1.InstanceMethod(); //Propiedad del valor 1
            instance2.InstanceMethod(); //Propiedad del valor 2

            var fibonacci8 =FibonacciNumberCalculator.GetFibonacciNumber(8);
            var fibonacci2 = FibonacciNumberCalculator.GetFibonacciNumber(7);
        }
    }


    public class ClassConInstancia
    {
        public int InstanceProperty { get; set; }
        public void InstanceMethod() { Console.WriteLine($"Property value :  {InstanceProperty}"); }
    }


    public class FibonacciNumberCalculator
    {
        public static int GetFibonacciNumber(int n)
        {

            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
            else if (n < 2) { return n; }
            else
            {
                var numbers = new List<int> { 0, 1 };
                for (int i = 2; i <= n; i++)
                {
                    numbers.Add(numbers[i - 1] + numbers[i - 2]);

                }
                return numbers[n];

            }
    }


    }

    public static class FibonacciNumberCalculator2 
    {
        public static int GetFibonacciNumber(int n)
        {

            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
            else if (n < 2) { return n; }
            else
            {
                var numbers = new List<int> { 0, 1 };
                for (int i = 2; i <= n; i++)
                {
                    numbers.Add(numbers[i - 1] + numbers[i - 2]);

                }
                return numbers[n];

            }
        }



    }
}

