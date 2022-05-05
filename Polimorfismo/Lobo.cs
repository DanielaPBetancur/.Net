using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
   public class Lobo : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El Lobo dice wooof");
        }
    }
}
