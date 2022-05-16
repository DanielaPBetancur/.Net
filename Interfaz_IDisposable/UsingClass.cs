using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Interfaz_IDisposable
{
    class UsingClass
    {

        public void UsingExample()
        {
            Char[] buffer = new Char[50];
            using (StreamReader s = new StreamReader("File1.txt"))
            {
                int charsRead = 0;
                while (s.Peek() != -1)
                {
                    charsRead = s.Read(buffer, 0, buffer.Length);

                }

            }
        }
    }
}


        
        


    

