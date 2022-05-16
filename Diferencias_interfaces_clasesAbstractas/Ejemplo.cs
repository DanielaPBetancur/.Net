using System;

namespace Diferencias_interfaces_clasesAbstractas
{
    public abstract class Vehiculos
    {
        public void Mover()
        {
            Console.WriteLine("Moviendo{0} ruedas", Ruedas);
        }

        public abstract int Ruedas { get; }
    }

    public class Coche : Vehiculos
    {

        public override int Ruedas
        {
            get { return 4; }

        }

    }

    public class Bicicleta : Vehiculos
    {
        public override int Ruedas
        {
            get { return 2; }
        }
    }

    ////////////Interfaces///////

    public interface IVehiculos
    {
        int Ruedas{ get; }
        
    }

    public interface CocheI : IVehiculos
    {
        public int Ruedas
        {

             get{ return 4; }
        }
    }


    public interface BicicletaI : IVehiculos
    {
        public int Ruedas
        {

            get { return 2; }
        }
    }



}
