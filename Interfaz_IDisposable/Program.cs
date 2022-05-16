using Interfaz_IDisposable;
using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace Interfaz_IDisposable
{
    class BaseClass : IDisposable
    {
        //Dispose se usa para liberar recursos no administrados que la app usa 


        bool disposed = false;

        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                handle.Dispose();
            }

        }
    }
}

    class DerivedClass : BaseClass
{

    //Dispose se usa para liberar recursos no administrados que la app usa 


    bool disposed = false;

    SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Hello World!");
    //}

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected override void Dispose(bool disposing)
    {
        if (disposed)
        {
            return;
        }
        if (disposing)
        {
            handle.Dispose();
        }

    }
}

