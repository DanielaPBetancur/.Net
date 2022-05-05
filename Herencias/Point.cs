using System;
using System.Collections.Generic;
using System.Text;

namespace Herencias
{
    public class Point
    {
        //Solo se pueden acceder a estas propiedades desde la misma clase (al ser private) 
        public int x { get; set; }
        public int y { get; set; }


        public void SetX(int value)
        {
            if (value < 100)
            {
                x = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public void SetY(int value)
        {
            if (value < 50)
            {
                y = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }


        public int GetX()
        {

            return x;

        }


        public int GetY()
        {

            return y;

        }


    }
}
