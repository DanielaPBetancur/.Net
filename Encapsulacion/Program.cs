using System;

namespace Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(); 
            point.x = 5000;

            try
            {
                PointEncapsulado pointEnc = new PointEncapsulado();

                pointEnc.SetX(102);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
                throw;
            }
            
        }
    }
}
