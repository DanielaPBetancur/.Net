using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El perro dice wooof");
        }
    }
}
