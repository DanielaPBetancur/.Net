using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias
{

    //Solo se puede heredar de una clase 
    public class Point3D : Point
    {
        public int Z { get; set; }

        public void SetZ(int value)
        {
            if (value < 30)
            {
                Z = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public int GetZ()
        {

            return Z;

        }




    }
}



