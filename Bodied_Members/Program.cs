using System;

namespace Bodied_Members
{
    class Student

    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        //Sobrecarga de clase string


        //Primera forma
        //public override string ToString()
        //{
        //    return $"{FullName},{Age}";
        //}

        //Segunda forma con expresion lambda
        public override string ToString() => $"{FullName},{Age}";


        //Tercera forma, metiendo condicional en if 
        private int age;
        private int Age2 
        {
            get => age;
            set => age = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value)); 
        
        }

        //Bodied members tambien se usa para contructores
        //public Student(string name, string surname, string age)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Age = age;
        //}


        //Creando constructor con expresion lambda
        public Student(string name, string surname, string age) =>( Name , Surname,Age) = (name,surname, age);
         
        









    }
}
