using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos_De_Extension
{
    public static class MyExtensions
    {
        public static int WordCount(this string str) 
        {
            return str.Split(new char[] {' ','.','?' },
                  StringSplitOptions.RemoveEmptyEntries).Length;
        
        }

    }
}
